namespace Logazar.WinForms
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegex = new System.Windows.Forms.Button();
            this.btnIgnoreCase = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnPretty = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lvResult = new System.Windows.Forms.ListView();
            this.tbCurrentEntry = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
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
            this.panelTop.Size = new System.Drawing.Size(800, 30);
            this.panelTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(632, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegex
            // 
            this.btnRegex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegex.Enabled = false;
            this.btnRegex.Location = new System.Drawing.Point(3, 3);
            this.btnRegex.Name = "btnRegex";
            this.btnRegex.Size = new System.Drawing.Size(24, 23);
            this.btnRegex.TabIndex = 5;
            this.btnRegex.Text = ".*";
            this.btnRegex.UseVisualStyleBackColor = true;
            this.btnRegex.Click += new System.EventHandler(this.btnRegex_Click);
            // 
            // btnIgnoreCase
            // 
            this.btnIgnoreCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIgnoreCase.Enabled = false;
            this.btnIgnoreCase.Location = new System.Drawing.Point(33, 3);
            this.btnIgnoreCase.Name = "btnIgnoreCase";
            this.btnIgnoreCase.Size = new System.Drawing.Size(29, 23);
            this.btnIgnoreCase.TabIndex = 6;
            this.btnIgnoreCase.Text = "aA";
            this.btnIgnoreCase.UseVisualStyleBackColor = true;
            this.btnIgnoreCase.Click += new System.EventHandler(this.btnIgnoreCase_Click);
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPin.Enabled = false;
            this.btnPin.Location = new System.Drawing.Point(695, 3);
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
            this.btnConfigure.Location = new System.Drawing.Point(730, 3);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(40, 23);
            this.btnConfigure.TabIndex = 3;
            this.btnConfigure.Text = "conf";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Enabled = false;
            this.btnInfo.Location = new System.Drawing.Point(776, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(21, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tbSearchField
            // 
            this.tbSearchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchField.Location = new System.Drawing.Point(68, 5);
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(558, 20);
            this.tbSearchField.TabIndex = 0;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCopy);
            this.panelBottom.Controls.Add(this.btnStandard);
            this.panelBottom.Controls.Add(this.btnPretty);
            this.panelBottom.Controls.Add(this.btnOriginal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 398);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 30);
            this.panelBottom.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(3, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(57, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStandard.Enabled = false;
            this.btnStandard.Location = new System.Drawing.Point(632, 3);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(57, 23);
            this.btnStandard.TabIndex = 1;
            this.btnStandard.Text = "standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnPretty
            // 
            this.btnPretty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretty.Enabled = false;
            this.btnPretty.Location = new System.Drawing.Point(695, 3);
            this.btnPretty.Name = "btnPretty";
            this.btnPretty.Size = new System.Drawing.Size(48, 23);
            this.btnPretty.TabIndex = 2;
            this.btnPretty.Text = "pretty";
            this.btnPretty.UseVisualStyleBackColor = true;
            this.btnPretty.Click += new System.EventHandler(this.btnPretty_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginal.Enabled = false;
            this.btnOriginal.Location = new System.Drawing.Point(749, 3);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(48, 23);
            this.btnOriginal.TabIndex = 3;
            this.btnOriginal.Text = "original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 30);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvResult);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbCurrentEntry);
            this.splitContainer.Size = new System.Drawing.Size(800, 368);
            this.splitContainer.SplitterDistance = 173;
            this.splitContainer.TabIndex = 1;
            // 
            // lvResult
            // 
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.Location = new System.Drawing.Point(0, 0);
            this.lvResult.MultiSelect = false;
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(800, 173);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
            this.lvResult.Click += new System.EventHandler(this.lvResult_Click);
            // 
            // tbCurrentEntry
            // 
            this.tbCurrentEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentEntry.Location = new System.Drawing.Point(0, 0);
            this.tbCurrentEntry.Multiline = true;
            this.tbCurrentEntry.Name = "tbCurrentEntry";
            this.tbCurrentEntry.ReadOnly = true;
            this.tbCurrentEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCurrentEntry.Size = new System.Drawing.Size(800, 191);
            this.tbCurrentEntry.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMain";
            this.Text = "Logazar";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
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
    }
}

