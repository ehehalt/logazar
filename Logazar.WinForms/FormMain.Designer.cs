﻿namespace Logazar.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnPurge = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegex = new System.Windows.Forms.Button();
            this.btnIgnoreCase = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.btnExportSQL = new System.Windows.Forms.Button();
            this.btnFilterDescribe = new System.Windows.Forms.Button();
            this.btnFilterCompile = new System.Windows.Forms.Button();
            this.labelFilterTypes = new System.Windows.Forms.Label();
            this.btnExportORG = new System.Windows.Forms.Button();
            this.btnExportMD = new System.Windows.Forms.Button();
            this.labelExport = new System.Windows.Forms.Label();
            this.btnRotateLayout = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnPretty = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lvResult = new System.Windows.Forms.ListView();
            this.tbCurrentEntry = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnFilterConnect = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(909, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel.Text = "...";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTop.Controls.Add(this.btnPurge);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnRegex);
            this.panelTop.Controls.Add(this.btnIgnoreCase);
            this.panelTop.Controls.Add(this.btnPin);
            this.panelTop.Controls.Add(this.btnConfigure);
            this.panelTop.Controls.Add(this.btnInfo);
            this.panelTop.Controls.Add(this.tbSearchField);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(909, 30);
            this.panelTop.TabIndex = 0;
            // 
            // btnPurge
            // 
            this.btnPurge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPurge.Location = new System.Drawing.Point(788, 3);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(45, 23);
            this.btnPurge.TabIndex = 7;
            this.btnPurge.Text = "purge";
            this.toolTip.SetToolTip(this.btnPurge, "Remove the log entries from the file ...");
            this.btnPurge.UseVisualStyleBackColor = true;
            this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(690, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "refresh";
            this.toolTip.SetToolTip(this.btnRefresh, "Reload data from the log file ...");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegex
            // 
            this.btnRegex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegex.Location = new System.Drawing.Point(3, 3);
            this.btnRegex.Name = "btnRegex";
            this.btnRegex.Size = new System.Drawing.Size(24, 23);
            this.btnRegex.TabIndex = 5;
            this.btnRegex.Text = ".*";
            this.toolTip.SetToolTip(this.btnRegex, "Toggle Regular Expressions ...");
            this.btnRegex.UseVisualStyleBackColor = true;
            this.btnRegex.Click += new System.EventHandler(this.btnRegex_Click);
            // 
            // btnIgnoreCase
            // 
            this.btnIgnoreCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIgnoreCase.Location = new System.Drawing.Point(33, 3);
            this.btnIgnoreCase.Name = "btnIgnoreCase";
            this.btnIgnoreCase.Size = new System.Drawing.Size(29, 23);
            this.btnIgnoreCase.TabIndex = 6;
            this.btnIgnoreCase.Text = "aA";
            this.toolTip.SetToolTip(this.btnIgnoreCase, "Toggle Ignore Case ...");
            this.btnIgnoreCase.UseVisualStyleBackColor = true;
            this.btnIgnoreCase.Click += new System.EventHandler(this.btnIgnoreCase_Click);
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPin.Location = new System.Drawing.Point(753, 3);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(29, 23);
            this.btnPin.TabIndex = 2;
            this.btnPin.Text = "pin";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigure.Enabled = false;
            this.btnConfigure.Location = new System.Drawing.Point(839, 3);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(40, 23);
            this.btnConfigure.TabIndex = 3;
            this.btnConfigure.Text = "conf";
            this.toolTip.SetToolTip(this.btnConfigure, "Configure Logazar ...");
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Enabled = false;
            this.btnInfo.Location = new System.Drawing.Point(885, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(21, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "?";
            this.toolTip.SetToolTip(this.btnInfo, "Help and version infos");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tbSearchField
            // 
            this.tbSearchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchField.Location = new System.Drawing.Point(68, 5);
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(616, 20);
            this.tbSearchField.TabIndex = 0;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // btnExportSQL
            // 
            this.btnExportSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportSQL.Location = new System.Drawing.Point(363, 3);
            this.btnExportSQL.Name = "btnExportSQL";
            this.btnExportSQL.Size = new System.Drawing.Size(30, 23);
            this.btnExportSQL.TabIndex = 8;
            this.btnExportSQL.Text = "sql";
            this.btnExportSQL.UseVisualStyleBackColor = true;
            this.btnExportSQL.Click += new System.EventHandler(this.btnExportSQL_Click);
            // 
            // btnFilterDescribe
            // 
            this.btnFilterDescribe.Location = new System.Drawing.Point(161, 3);
            this.btnFilterDescribe.Name = "btnFilterDescribe";
            this.btnFilterDescribe.Size = new System.Drawing.Size(38, 23);
            this.btnFilterDescribe.TabIndex = 13;
            this.btnFilterDescribe.Text = "dsc";
            this.toolTip.SetToolTip(this.btnFilterDescribe, "Filter \"Describe\"");
            this.btnFilterDescribe.UseVisualStyleBackColor = true;
            this.btnFilterDescribe.Click += new System.EventHandler(this.btnFilterDescribe_Click);
            // 
            // btnFilterCompile
            // 
            this.btnFilterCompile.Location = new System.Drawing.Point(117, 3);
            this.btnFilterCompile.Name = "btnFilterCompile";
            this.btnFilterCompile.Size = new System.Drawing.Size(38, 23);
            this.btnFilterCompile.TabIndex = 13;
            this.btnFilterCompile.Text = "cmp";
            this.toolTip.SetToolTip(this.btnFilterCompile, "Filter \"compile\"");
            this.btnFilterCompile.UseVisualStyleBackColor = true;
            this.btnFilterCompile.Click += new System.EventHandler(this.btnFilterCompile_Click);
            // 
            // labelFilterTypes
            // 
            this.labelFilterTypes.Location = new System.Drawing.Point(85, 0);
            this.labelFilterTypes.Name = "labelFilterTypes";
            this.labelFilterTypes.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelFilterTypes.Size = new System.Drawing.Size(26, 23);
            this.labelFilterTypes.TabIndex = 12;
            this.labelFilterTypes.Text = "filter";
            this.labelFilterTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportORG
            // 
            this.btnExportORG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportORG.Location = new System.Drawing.Point(291, 3);
            this.btnExportORG.Name = "btnExportORG";
            this.btnExportORG.Size = new System.Drawing.Size(30, 23);
            this.btnExportORG.TabIndex = 11;
            this.btnExportORG.Text = "org";
            this.btnExportORG.UseVisualStyleBackColor = true;
            this.btnExportORG.Click += new System.EventHandler(this.btnExportORG_Click);
            // 
            // btnExportMD
            // 
            this.btnExportMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportMD.Location = new System.Drawing.Point(327, 3);
            this.btnExportMD.Name = "btnExportMD";
            this.btnExportMD.Size = new System.Drawing.Size(30, 23);
            this.btnExportMD.TabIndex = 10;
            this.btnExportMD.Text = "md";
            this.btnExportMD.UseVisualStyleBackColor = true;
            this.btnExportMD.Click += new System.EventHandler(this.btnExportMD_Click);
            // 
            // labelExport
            // 
            this.labelExport.Location = new System.Drawing.Point(249, 0);
            this.labelExport.Name = "labelExport";
            this.labelExport.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelExport.Size = new System.Drawing.Size(36, 23);
            this.labelExport.TabIndex = 9;
            this.labelExport.Text = "export";
            this.labelExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotateLayout
            // 
            this.btnRotateLayout.Location = new System.Drawing.Point(3, 3);
            this.btnRotateLayout.Name = "btnRotateLayout";
            this.btnRotateLayout.Size = new System.Drawing.Size(76, 23);
            this.btnRotateLayout.TabIndex = 4;
            this.btnRotateLayout.Text = "rotate layout";
            this.toolTip.SetToolTip(this.btnRotateLayout, "Rotate the layout from horizontal to vertical and vice versa ...");
            this.btnRotateLayout.UseVisualStyleBackColor = true;
            this.btnRotateLayout.Click += new System.EventHandler(this.btnRotateLayout_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(399, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(57, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "copy";
            this.toolTip.SetToolTip(this.btnCopy, "copy complete entry to the clipboard ...");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStandard.Location = new System.Drawing.Point(504, 3);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(57, 23);
            this.btnStandard.TabIndex = 1;
            this.btnStandard.Text = "standard";
            this.toolTip.SetToolTip(this.btnStandard, "Standard layout (data extracted from log file) ...");
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnPretty
            // 
            this.btnPretty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretty.Location = new System.Drawing.Point(567, 3);
            this.btnPretty.Name = "btnPretty";
            this.btnPretty.Size = new System.Drawing.Size(48, 23);
            this.btnPretty.TabIndex = 2;
            this.btnPretty.Text = "pretty";
            this.toolTip.SetToolTip(this.btnPretty, "Standard format in a prettyfied version ...");
            this.btnPretty.UseVisualStyleBackColor = true;
            this.btnPretty.Click += new System.EventHandler(this.btnPretty_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginal.Location = new System.Drawing.Point(621, 3);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(48, 23);
            this.btnOriginal.TabIndex = 3;
            this.btnOriginal.Text = "original";
            this.toolTip.SetToolTip(this.btnOriginal, "The original lines from the log file ...");
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 30);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvResult);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbCurrentEntry);
            this.splitContainer.Size = new System.Drawing.Size(909, 369);
            this.splitContainer.SplitterDistance = 452;
            this.splitContainer.TabIndex = 1;
            // 
            // lvResult
            // 
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(0, 0);
            this.lvResult.MultiSelect = false;
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(452, 369);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
            this.lvResult.Click += new System.EventHandler(this.lvResult_Click);
            // 
            // tbCurrentEntry
            // 
            this.tbCurrentEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentEntry.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentEntry.Location = new System.Drawing.Point(0, 0);
            this.tbCurrentEntry.Multiline = true;
            this.tbCurrentEntry.Name = "tbCurrentEntry";
            this.tbCurrentEntry.ReadOnly = true;
            this.tbCurrentEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCurrentEntry.Size = new System.Drawing.Size(453, 369);
            this.tbCurrentEntry.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoSize = true;
            this.panelBottom.Controls.Add(this.btnRotateLayout);
            this.panelBottom.Controls.Add(this.labelFilterTypes);
            this.panelBottom.Controls.Add(this.btnFilterCompile);
            this.panelBottom.Controls.Add(this.btnFilterDescribe);
            this.panelBottom.Controls.Add(this.btnFilterConnect);
            this.panelBottom.Controls.Add(this.labelExport);
            this.panelBottom.Controls.Add(this.btnExportORG);
            this.panelBottom.Controls.Add(this.btnExportMD);
            this.panelBottom.Controls.Add(this.btnExportSQL);
            this.panelBottom.Controls.Add(this.btnCopy);
            this.panelBottom.Controls.Add(this.labelResult);
            this.panelBottom.Controls.Add(this.btnStandard);
            this.panelBottom.Controls.Add(this.btnPretty);
            this.panelBottom.Controls.Add(this.btnOriginal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 399);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(909, 29);
            this.panelBottom.TabIndex = 14;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(462, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelResult.Size = new System.Drawing.Size(36, 23);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilterConnect
            // 
            this.btnFilterConnect.Location = new System.Drawing.Point(205, 3);
            this.btnFilterConnect.Name = "btnFilterConnect";
            this.btnFilterConnect.Size = new System.Drawing.Size(38, 23);
            this.btnFilterConnect.TabIndex = 14;
            this.btnFilterConnect.Text = "con";
            this.toolTip.SetToolTip(this.btnFilterConnect, "Filter \"Connect\"");
            this.btnFilterConnect.UseVisualStyleBackColor = true;
            this.btnFilterConnect.Click += new System.EventHandler(this.btnFilterConnect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Logazar";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.TextBox tbCurrentEntry;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.TextBox tbSearchField;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnIgnoreCase;
        private System.Windows.Forms.Button btnRegex;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnPretty;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRotateLayout;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnExportSQL;
        private System.Windows.Forms.Button btnExportORG;
        private System.Windows.Forms.Button btnExportMD;
        private System.Windows.Forms.Label labelExport;
        private System.Windows.Forms.Label labelFilterTypes;
        private System.Windows.Forms.Button btnFilterCompile;
        private System.Windows.Forms.Button btnFilterDescribe;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnFilterConnect;
    }
}

