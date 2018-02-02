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
            this.wv = new System.Windows.Forms.WebBrowser();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MedicalRecortSampleD1 = new PatientManagement.MedicalRecortSampleD();
            this.btnModel = new System.Windows.Forms.Button();
            this.MedicalRecortSampleC1 = new PatientManagement.MedicalRecortSampleC();
            this.MedicalReportSampleB1 = new PatientManagement.MedicalReportSampleB();
            this.MedicalReportSampleA1 = new PatientManagement.MedicalReportSampleA();
            this.pnBoss.SuspendLayout();
            this.pnMiddle.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMiddle);
            this.pnBoss.Controls.Add(this.pnTop);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1129, 776);
            this.pnBoss.TabIndex = 1;
            // 
            // pnMiddle
            // 
            this.pnMiddle.Controls.Add(this.wv);
            this.pnMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(1129, 725);
            this.pnMiddle.TabIndex = 2;
            // 
            // wv
            // 
            this.wv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wv.Location = new System.Drawing.Point(0, 0);
            this.wv.MinimumSize = new System.Drawing.Size(20, 20);
            this.wv.Name = "wv";
            this.wv.Size = new System.Drawing.Size(1129, 725);
            this.wv.TabIndex = 1;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnPrintPreview);
            this.pnTop.Controls.Add(this.cmbModel);
            this.pnTop.Controls.Add(this.btnPrint);
            this.pnTop.Controls.Add(this.crystalReportViewer);
            this.pnTop.Controls.Add(this.btnModel);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1129, 51);
            this.pnTop.TabIndex = 1;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(16, 10);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(132, 23);
            this.btnPrintPreview.TabIndex = 4;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "SampleA",
            "SampleB",
            "SampleC",
            "SampleD"});
            this.cmbModel.Location = new System.Drawing.Point(316, 12);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(161, 21);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(16, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(235, 10);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(75, 23);
            this.btnModel.TabIndex = 0;
            this.btnModel.Text = "Content";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // MedicalRecordWebViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 776);
            this.Controls.Add(this.pnBoss);
            this.Name = "MedicalRecordWebViewer";
            this.Text = "web";
            this.Load += new System.EventHandler(this.MedicalRecordWebViewer_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMiddle.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Panel pnMiddle;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnModel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.WebBrowser wv;
        private System.Windows.Forms.Button btnPrint;
        private MedicalReportSampleA MedicalReportSampleA1;
        private MedicalReportSampleB MedicalReportSampleB1;
        private System.Windows.Forms.ComboBox cmbModel;
        private MedicalRecortSampleC MedicalRecortSampleC1;
        private MedicalRecortSampleD MedicalRecortSampleD1;
        private System.Windows.Forms.Button btnPrintPreview;
    }
}