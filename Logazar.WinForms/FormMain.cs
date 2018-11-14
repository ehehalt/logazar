using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Logazar.WinForms
{
    public partial class FormMain : Form
    {
        #region Enumerations

        private enum ResultTypeEnum
        {
            Standard,
            Pretty,
            Original
        }

        private enum ExportTypeEnum
        {
            SQL,
            Markdown,
            OrgMode
        }

        #endregion Enumerations
        #region Properties

        // Todo: save properties in config file
        private ResultTypeEnum ResultType { get; set; } = ResultTypeEnum.Standard;
        private Boolean SearchRegex { get; set; } = true;
        private Boolean Pinned { get; set; } = false;
        private DateTime PinnedTime { get; set; } = DateTime.MinValue;
        private Boolean SearchCaseSensitive { get; set; } = false;
        private LogFile logFile { get; set; }

        #endregion Properties
        #region Constructor(s)

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion Constructor(s)
        #region Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            ListViewResultConfig();
            Buttons_Load();
            LogData_Load();
            Title_Load();
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {
            SearchRegex = !SearchRegex;
            SearchButtons_Load();
            LvResult_ShowData();
        }

        private void btnIgnoreCase_Click(object sender, EventArgs e)
        {
            SearchCaseSensitive = !SearchCaseSensitive;
            SearchButtons_Load();
            LvResult_ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LogData_Load();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            Pinned = !Pinned;
            PinnedTime = DateTime.Now;
            SearchButtons_Load();
            LvResult_ShowData();
        }


        private void btnExportSQL_Click(object sender, EventArgs e)
        {
            ExportFile(ExportTypeEnum.SQL);
        }

        private void btnExportMD_Click(object sender, EventArgs e)
        {
            ExportFile(ExportTypeEnum.Markdown);
        }

        private void btnExportORG_Click(object sender, EventArgs e)
        {
            ExportFile(ExportTypeEnum.OrgMode);
        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            PurgeLogfile();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCurrentEntry.Text);
        }

        private void btnRotateLayout_Click(object sender, EventArgs e)
        {
            if (splitContainer.Orientation == Orientation.Horizontal)
            {
                splitContainer.Orientation = Orientation.Vertical;
            }
            else
            {
                splitContainer.Orientation = Orientation.Horizontal;
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            ResultType = ResultTypeEnum.Standard;
            CurrentEntryButtons_Load();
        }

        private void btnPretty_Click(object sender, EventArgs e)
        {
            ResultType = ResultTypeEnum.Pretty;
            CurrentEntryButtons_Load();
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            ResultType = ResultTypeEnum.Original;
            CurrentEntryButtons_Load();
        }

        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            LvResult_ShowData();
        }

        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbCurrentEntry_ShowData();
        }

        private void lvResult_Click(object sender, EventArgs e)
        {
            TbCurrentEntry_ShowData();
        }

        #endregion Events
        #region Methods

        private void ListViewResultConfig()
        {
            lvResult.View = View.Details;
            lvResult.HideSelection = false;
            lvResult.Columns.Add("date", "date", 110);
            lvResult.Columns.Add("level", "level", 0);
            lvResult.Columns.Add("type", "type", 100);
            lvResult.Columns.Add("data", "data", ListViewResultDataWidth());
            lvResult.ColumnWidthChanged += LvResult_ColumnWidthChanged;
        }

        private int ListViewResultDataWidth()
        {
            // calculate the data column size to fit in the listview without needing a horizontal scrollbar
            int width = 25;
            foreach (ColumnHeader col in lvResult.Columns)
            {
                if (col.Name != "data")
                    width += col.Width;

            }
            return lvResult.Width - width;
        }

        private void LvResult_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            // while changing a columns size, resize the data column to fit to the right
            if (e.ColumnIndex != lvResult.Columns["data"].Index)
            {
                lvResult.Columns["data"].Width = ListViewResultDataWidth();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            lvResult.Columns["data"].Width = ListViewResultDataWidth();
        }

        private void LogData_Load()
        {
            // prototyped
            try
            {
                // Todo: make logfile configurable
                logFile = new LogFile(@"C:\Temp\guptaora.log");
                logFile.Load();
                toolStripStatusLabel.Text = $"guptaora.log loaded: {logFile.Entries.Count} entries found ...";
                LvResult_ShowData();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = $"Error: {ex.Message} ...";
            }
        }

        private void Title_Load()
        {
            this.Text = $"Logazar {GetVersionString()}";
        }

        private string GetVersionString()
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            String versionString = version.Major + "." + version.Minor + "." + version.Build;
            return versionString;
        }

        private void Buttons_Load()
        {
            SearchButtons_Load();
            CurrentEntryButtons_Load();
            TbCurrentEntry_ShowData();
        }

        private void LvResult_ShowData()
        {
            lvResult.BeginUpdate();
            lvResult.Items.Clear();
            try
            {
                var entries = logFile.Entries
                    .Reverse()
                    .Where(entry => entry.Type == LogFile.COMPILE);

                if (Pinned)
                    entries = entries.Where(entry => entry.TimeStamp >= PinnedTime);

                if (SearchRegex)
                {
                    Regex rx = new Regex(tbSearchField.Text, SearchCaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
                    entries = entries.Where(entry => rx.IsMatch(entry.Data));
                }
                else
                {
                    if (SearchCaseSensitive)
                    {
                        entries = entries.Where(entry => entry.Data.ToString().Contains(tbSearchField.Text));
                    }
                    else
                    {
                        entries = entries.Where(entry => entry.Data.ToString().ToUpper().Contains(tbSearchField.Text.ToUpper()));
                    }
                }

                foreach (LogEntry entry in entries)
                {
                    var item = new ListViewItem(new String[] { entry.TimeStampString, entry.Level, entry.Type, entry.Data });
                    item.Tag = entry;
                    lvResult.Items.Add(item);
                }
                toolStripStatusLabel.Text = $"Filtered: {entries.Count()}/{logFile.Entries.Count()} ...";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = $"Regular Expression Error: {ex.Message}";
            }
            lvResult.EndUpdate();
            tbCurrentEntry.Text = "";
        }

        private void SearchButtons_Load()
        {
            HighlightButton(new Button[] { btnConfigure, btnInfo, btnPin }, false);

            HighlightButton(btnIgnoreCase, SearchCaseSensitive);
            HighlightButton(btnRegex, SearchRegex);

            HighlightButton(btnPin, Pinned);
        }

        private void CurrentEntryButtons_Load()
        {
            HighlightButton(new Button[] { btnStandard, btnPretty, btnOriginal }, false);
            switch (ResultType)
            {
                case ResultTypeEnum.Standard:
                    HighlightButton(btnStandard, true);
                    break;
                case ResultTypeEnum.Pretty:
                    HighlightButton(btnPretty, true);
                    break;
                case ResultTypeEnum.Original:
                    HighlightButton(btnOriginal, true);
                    break;
                default:
                    HighlightButton(btnStandard, true);
                    break;
            }

            TbCurrentEntry_ShowData();
        }

        private void TbCurrentEntry_ShowData()
        {
            if (lvResult.SelectedItems.Count > 0)
            {
                var item = lvResult.SelectedItems[0];
                if (item != null && item.Tag != null && item.Tag is LogEntry)
                {
                    var entry = item.Tag as LogEntry;
                    switch (ResultType)
                    {
                        case ResultTypeEnum.Standard:
                            tbCurrentEntry.Text = entry.Data;
                            break;
                        case ResultTypeEnum.Pretty:
                            tbCurrentEntry.Text = PrettifySql(entry.Data);
                            break;
                        case ResultTypeEnum.Original:
                            tbCurrentEntry.Text = entry.DataOriginal;
                            break;
                        default:
                            tbCurrentEntry.Text = entry.Data;
                            break;
                    }
                }
                else
                {
                    tbCurrentEntry.Text = "";
                }
            }
        }

        private void HighlightButton(IList<Button> buttons, Boolean highlight)
        {
            buttons.ToList().ForEach(button => HighlightButton(button, highlight));
        }
        private void HighlightButton(Button button, Boolean highlight)
        {
            if (highlight)
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor = Color.LightGray;
            }
        }

        private String PrettifySql(String statement)
        {
            // Todo: make sql formatter configurable ...
            // pip install --upgrade sqlparse

            var output = statement;

            var tempFileName = Path.GetTempFileName();
            File.WriteAllText(tempFileName, statement);

            try
            {
                Process p = new Process();
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = $"sqlformat";
                p.StartInfo.Arguments = $"-k upper -a {tempFileName}";
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = $"Error: {ex.Message}";
            }

            File.Delete(tempFileName);

            return output;
        }

        private void PurgeLogfile()
        {
            var filePart = Path.Combine(Path.GetDirectoryName(logFile.FilePath), Path.GetFileNameWithoutExtension(logFile.FilePath));
            var date = DateTime.Now;
            var datePart = $"{date.Year:d4}.{date.Month:d2}.{date.Day:d2}-{date.Hour:d2}.{date.Minute:d2}.{date.Second:d2}.{date.Millisecond:d3}";
            var extension = Path.GetExtension(logFile.FilePath);
            var newFilePath = $"{filePart}-{datePart}{extension}";

            File.Copy(logFile.FilePath, newFilePath);
            File.WriteAllText(logFile.FilePath, string.Empty);
            LogData_Load();
        }


        private void ExportFile(ExportTypeEnum exportType)
        {
            String extension;
            switch (exportType)
            {
                case ExportTypeEnum.SQL:
                    extension = ResultType == ResultTypeEnum.Original ? ".txt" : ".sql";
                    break;
                case ExportTypeEnum.Markdown:
                    extension = ".md";
                    break;
                case ExportTypeEnum.OrgMode:
                    extension = ".org";
                    break;
                default:
                    toolStripStatusLabel.Text = $"Error: Unknown export type ...";
                    return;
            }
            String filePath = logFile.FilePath + extension;

            try
            {
                String text = "";
                switch (exportType)
                {
                    case ExportTypeEnum.SQL:
                        text = "-- Guptaora.log" + Environment.NewLine;
                        break;
                    case ExportTypeEnum.Markdown:
                        text = "# Guptaora.log" + Environment.NewLine + Environment.NewLine;
                        break;
                    case ExportTypeEnum.OrgMode:
                        text = GetOrgModeHeader() + Environment.NewLine;
                        text += "* Guptaora.log" + Environment.NewLine;
                        break;
                }

                int idx = 1;
                foreach (LogEntry logEntry in logFile.Entries.Where(entry => entry.Type == LogFile.COMPILE))
                {
                    var logEntryIdentifier = $"{idx} - {logEntry.TimeStampString}";
                    switch (exportType)
                    {
                        case ExportTypeEnum.SQL:
                            text += $"-- {logEntryIdentifier}";
                            text += System.Environment.NewLine;
                            text += System.Environment.NewLine;
                            break;
                        case ExportTypeEnum.Markdown:
                            text += $"## Statement {logEntryIdentifier}";
                            text += Environment.NewLine;
                            text += Environment.NewLine;
                            text += ResultType == ResultTypeEnum.Original ? "```text" : "```sql";
                            text += Environment.NewLine;
                            break;
                        case ExportTypeEnum.OrgMode:
                            text += $"** Statement {logEntryIdentifier}";
                            text += Environment.NewLine;
                            text += Environment.NewLine;
                            text += ResultType == ResultTypeEnum.Original ? "#+BEGIN_SRC text" : "#+BEGIN_SRC sql";
                            text += Environment.NewLine;
                            break;
                    }

                    if (ResultType == ResultTypeEnum.Pretty)
                    {
                        text += PrettifySql(logEntry.Data);
                    }
                    else if (ResultType == ResultTypeEnum.Standard)
                    {
                        text += logEntry.Data.Trim();
                    }
                    else
                    {
                        text += logEntry.DataOriginal;
                    }
                    switch (exportType)
                    {
                        case ExportTypeEnum.SQL:
                            text += ";";
                            text += System.Environment.NewLine;
                            text += System.Environment.NewLine;
                            break;
                        case ExportTypeEnum.Markdown:
                            text += System.Environment.NewLine;
                            text += "```";
                            text += System.Environment.NewLine;
                            text += System.Environment.NewLine;
                            break;
                        case ExportTypeEnum.OrgMode:
                            text += ";";
                            text += System.Environment.NewLine;
                            text += "#+END_SRC";
                            text += System.Environment.NewLine;
                            text += System.Environment.NewLine;
                            break;
                    }


                    idx++;
                }

                File.WriteAllText(filePath, text);
                MessageBox.Show($"File '{filePath}' created successfully.", "Logazar - Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                toolStripStatusLabel.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Error while creating file '{filePath}':" + Environment.NewLine + ex.Message, "Logazar - Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetOrgModeHeader()
        {
            var lines = new List<String>();
            lines.Add($"#+TITLE: {logFile.FilePath}");
            lines.Add($"#+AUTHOR: {System.Environment.UserName}");
            lines.Add($"#+DATE: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            lines.Add($"#+DESCRIPTION: Guptaoralog.org create by Logazar {GetVersionString()}");
            lines.Add($"#+PROPERTY: header-args:sql :engine oracle :database dbname :dbuser username :dbpassword password");
            lines.Add("");

            return String.Join(System.Environment.NewLine, lines);
        }

        #endregion Methods
    }
}
