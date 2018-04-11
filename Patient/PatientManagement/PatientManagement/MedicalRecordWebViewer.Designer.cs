namespace PatientManagement
{
    partial class MedicalRecordWebViewer
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
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMiddle = new System.Windows.Forms.Panel();
            this.wvPrintSample = new System.Windows.Forms.WebBrowser();
            this.pnTop = new System.Windows.Forms.Panel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MedicalRecortSampleD1 = new PatientManagement.MedicalRecortSampleD();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripcmbModel = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsDefaultPrintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicalRecortSampleC1 = new PatientManagement.MedicalRecortSampleC();
            this.MedicalReportSampleA1 = new PatientManagement.MedicalReportSampleA();
            this.MedicalReportSampleB1 = new PatientManagement.MedicalReportSampleB();
            this.pnBoss.SuspendLayout();
            this.pnMiddle.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMiddle);
            this.pnBoss.Controls.Add(this.pnTop);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1129, 733);
            this.pnBoss.TabIndex = 1;
            // 
            // pnMiddle
            // 
            this.pnMiddle.Controls.Add(this.wvPrintSample);
            this.pnMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(1129, 682);
            this.pnMiddle.TabIndex = 2;
            // 
            // wvPrintSample
            // 
            this.wvPrintSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPrintSample.Location = new System.Drawing.Point(0, 0);
            this.wvPrintSample.Margin = new System.Windows.Forms.Padding(0);
            this.wvPrintSample.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvPrintSample.Name = "wvPrintSample";
            this.wvPrintSample.Size = new System.Drawing.Size(1129, 682);
            this.wvPrintSample.TabIndex = 1;
            this.wvPrintSample.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wvPrintSample_Navigated);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.crystalReportViewer);
            this.pnTop.Controls.Add(this.menuStrip1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1129, 51);
            this.pnTop.TabIndex = 1;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(1104, 11);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.MedicalRecortSampleD1;
            this.crystalReportViewer.Size = new System.Drawing.Size(22, 33);
            this.crystalReportViewer.TabIndex = 1;
            this.crystalReportViewer.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripcmbModel,
            this.printToolStripMenuItem,
            this.printDialogToolStripMenuItem,
            this.printPreviewDialogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 51);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripcmbModel
            // 
            this.toolStripcmbModel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sampleAToolStripMenuItem,
            this.sampleBToolStripMenuItem,
            this.sampleCToolStripMenuItem,
            this.sampleDToolStripMenuItem,
            this.setAsDefaultPrintToolStripMenuItem1});
            this.toolStripcmbModel.Name = "toolStripcmbModel";
            this.toolStripcmbModel.Size = new System.Drawing.Size(85, 47);
            this.toolStripcmbModel.Text = "Default Print";
            // 
            // sampleAToolStripMenuItem
            // 
            this.sampleAToolStripMenuItem.Name = "sampleAToolStripMenuItem";
            this.sampleAToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sampleAToolStripMenuItem.Text = "SampleA";
            this.sampleAToolStripMenuItem.Click += new System.EventHandler(this.sampleAToolStripMenuItem_Click);
            // 
            // sampleBToolStripMenuItem
            // 
            this.sampleBToolStripMenuItem.Name = "sampleBToolStripMenuItem";
            this.sampleBToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sampleBToolStripMenuItem.Text = "SampleB";
            this.sampleBToolStripMenuItem.Click += new System.EventHandler(this.sampleBToolStripMenuItem_Click);
            // 
            // sampleCToolStripMenuItem
            // 
            this.sampleCToolStripMenuItem.Name = "sampleCToolStripMenuItem";
            this.sampleCToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sampleCToolStripMenuItem.Text = "SampleC";
            this.sampleCToolStripMenuItem.Click += new System.EventHandler(this.sampleCToolStripMenuItem_Click);
            // 
            // sampleDToolStripMenuItem
            // 
            this.sampleDToolStripMenuItem.Name = "sampleDToolStripMenuItem";
            this.sampleDToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sampleDToolStripMenuItem.Text = "SampleD";
            this.sampleDToolStripMenuItem.Click += new System.EventHandler(this.sampleDToolStripMenuItem_Click);
            // 
            // setAsDefaultPrintToolStripMenuItem1
            // 
            this.setAsDefaultPrintToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem});
            this.setAsDefaultPrintToolStripMenuItem1.Name = "setAsDefaultPrintToolStripMenuItem1";
            this.setAsDefaultPrintToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.setAsDefaultPrintToolStripMenuItem1.Text = "Set As Default Print";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.dToolStripMenuItem.Text = "D";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 47);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printDialogToolStripMenuItem
            // 
            this.printDialogToolStripMenuItem.Name = "printDialogToolStripMenuItem";
            this.printDialogToolStripMenuItem.Size = new System.Drawing.Size(81, 47);
            this.printDialogToolStripMenuItem.Text = "Print Dialog";
            this.printDialogToolStripMenuItem.Click += new System.EventHandler(this.printDialogToolStripMenuItem_Click);
            // 
            // printPreviewDialogToolStripMenuItem
            // 
            this.printPreviewDialogToolStripMenuItem.Name = "printPreviewDialogToolStripMenuItem";
            this.printPreviewDialogToolStripMenuItem.Size = new System.Drawing.Size(125, 47);
            this.printPreviewDialogToolStripMenuItem.Text = "Print Preview Dialog";
            this.printPreviewDialogToolStripMenuItem.Click += new System.EventHandler(this.printPreviewDialogToolStripMenuItem_Click);
            // 
            // MedicalRecordWebViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 733);
            this.Controls.Add(this.pnBoss);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MedicalRecordWebViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.MedicalRecordWebViewer_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMiddle.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Panel pnMiddle;
        private System.Windows.Forms.Panel pnTop;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.WebBrowser wvPrintSample;
        private MedicalReportSampleA MedicalReportSampleA1;
        private MedicalReportSampleB MedicalReportSampleB1;
        private MedicalRecortSampleC MedicalRecortSampleC1;
        private MedicalRecortSampleD MedicalRecortSampleD1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripcmbModel;
        private System.Windows.Forms.ToolStripMenuItem sampleAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsDefaultPrintToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
    }
}