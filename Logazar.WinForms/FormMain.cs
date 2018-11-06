using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logazar.WinForms
{
    public partial class FormMain : Form
    {
        private LogFile logFile { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        #region Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            ListViewResultConfig();

            LogData_Load();
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {

        }

        private void btnIgnoreCase_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LogData_Load();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {

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

        private void btnStandard_Click(object sender, EventArgs e)
        {

        }

        private void btnPretty_Click(object sender, EventArgs e)
        {

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {

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
            foreach(ColumnHeader col in lvResult.Columns)
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

        private void LvResult_ShowData()
        {
            lvResult.BeginUpdate();
            lvResult.Items.Clear();
            try
            {
                var entries = logFile.Entries
                    .Reverse()
                    .Where(entry => Regex.IsMatch(entry.Data, tbSearchField.Text, RegexOptions.IgnoreCase))
                    .Where(entry => entry.Type == LogFile.COMPILE);

                foreach (LogEntry entry in entries)
                {
                    var item = new ListViewItem(new String[] { entry.TimeStampString, entry.Level, entry.Type, entry.Data });
                    item.Tag = entry;
                    lvResult.Items.Add(item);
                }
                toolStripStatusLabel.Text = $"Filtered: {entries.Count()}/{logFile.Entries.Count()} ...";
            }
            catch(Exception ex)
            {
                toolStripStatusLabel.Text = $"Regular Expression Error: {ex.Message}";
            }
            lvResult.EndUpdate();
            tbCurrentEntry.Text = "";
        }

        private void TbCurrentEntry_ShowData()
        {
            if(lvResult.SelectedItems.Count > 0)
            {
                var item = lvResult.SelectedItems[0];
                if (item != null && item.Tag != null && item.Tag is LogEntry)
                {
                    var entry = item.Tag as LogEntry;
                    tbCurrentEntry.Text = entry.Data;
                }
                else
                {
                    tbCurrentEntry.Text = "";
                }
            }
        }

    }
}
