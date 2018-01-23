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
            this.wvMedicalRecord = new System.Windows.Forms.WebBrowser();
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMiddle = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MedicalReports1 = new PatientManagement.MedicalReports();
            this.pnBoss.SuspendLayout();
            this.pnMiddle.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // wvMedicalRecord
            // 
            this.wvMedicalRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvMedicalRecord.Location = new System.Drawing.Point(0, 0);
            this.wvMedicalRecord.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvMedicalRecord.Name = "wvMedicalRecord";
            this.wvMedicalRecord.Size = new System.Drawing.Size(998, 725);
            this.wvMedicalRecord.TabIndex = 0;
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMiddle);
            this.pnBoss.Controls.Add(this.pnTop);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(998, 776);
            this.pnBoss.TabIndex = 1;
            // 
            // pnMiddle
            // 
            this.pnMiddle.Controls.Add(this.wvMedicalRecord);
            this.pnMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(998, 725);
            this.pnMiddle.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.crystalReportViewer);
            this.pnTop.Controls.Add(this.btnPrint);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(998, 51);
            this.pnTop.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(7, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(697, 12);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.MedicalReports1;
            this.crystalReportViewer.Size = new System.Drawing.Size(289, 22);
            this.crystalReportViewer.TabIndex = 1;
            this.crystalReportViewer.Visible = false;
            // 
            // MedicalRecordWebViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 776);
            this.Controls.Add(this.pnBoss);
            this.Name = "MedicalRecordWebViewer";
            this.Text = "MedicalRecordWebViewer";
            this.Load += new System.EventHandler(this.MedicalRecordWebViewer_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMiddle.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wvMedicalRecord;
        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Panel pnMiddle;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private MedicalReports MedicalReports1;
    }
}