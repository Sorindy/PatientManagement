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
            this.wvSampleD = new System.Windows.Forms.WebBrowser();
            this.wvSampleC = new System.Windows.Forms.WebBrowser();
            this.wvSampleB = new System.Windows.Forms.WebBrowser();
            this.wvSampleA = new System.Windows.Forms.WebBrowser();
            this.pnTop = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MedicalRecortSampleD1 = new PatientManagement.MedicalRecortSampleD();
            this.MedicalRecortSampleC1 = new PatientManagement.MedicalRecortSampleC();
            this.MedicalReportSampleA1 = new PatientManagement.MedicalReportSampleA();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.MedicalReportSampleB1 = new PatientManagement.MedicalReportSampleB();
            this.pnBoss.SuspendLayout();
            this.pnMiddle.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.tblypnTop.SuspendLayout();
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
            this.pnMiddle.Controls.Add(this.wvSampleD);
            this.pnMiddle.Controls.Add(this.wvSampleC);
            this.pnMiddle.Controls.Add(this.wvSampleB);
            this.pnMiddle.Controls.Add(this.wvSampleA);
            this.pnMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(1129, 682);
            this.pnMiddle.TabIndex = 2;
            // 
            // wvSampleD
            // 
            this.wvSampleD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvSampleD.Location = new System.Drawing.Point(0, 0);
            this.wvSampleD.Margin = new System.Windows.Forms.Padding(0);
            this.wvSampleD.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvSampleD.Name = "wvSampleD";
            this.wvSampleD.Size = new System.Drawing.Size(1129, 682);
            this.wvSampleD.TabIndex = 4;
            // 
            // wvSampleC
            // 
            this.wvSampleC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvSampleC.Location = new System.Drawing.Point(0, 0);
            this.wvSampleC.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvSampleC.Name = "wvSampleC";
            this.wvSampleC.ScrollBarsEnabled = false;
            this.wvSampleC.Size = new System.Drawing.Size(1129, 682);
            this.wvSampleC.TabIndex = 3;
            // 
            // wvSampleB
            // 
            this.wvSampleB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvSampleB.Location = new System.Drawing.Point(0, 0);
            this.wvSampleB.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvSampleB.Name = "wvSampleB";
            this.wvSampleB.Size = new System.Drawing.Size(1129, 682);
            this.wvSampleB.TabIndex = 2;
            // 
            // wvSampleA
            // 
            this.wvSampleA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvSampleA.Location = new System.Drawing.Point(0, 0);
            this.wvSampleA.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvSampleA.Name = "wvSampleA";
            this.wvSampleA.ScrollBarsEnabled = false;
            this.wvSampleA.Size = new System.Drawing.Size(1129, 682);
            this.wvSampleA.TabIndex = 1;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.tblypnTop);
            this.pnTop.Controls.Add(this.crystalReportViewer);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1129, 51);
            this.pnTop.TabIndex = 1;
            // 
            // tblypnTop
            // 
            this.tblypnTop.ColumnCount = 4;
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblypnTop.Controls.Add(this.btnPrintDialog, 2, 0);
            this.tblypnTop.Controls.Add(this.cmbModel, 0, 0);
            this.tblypnTop.Controls.Add(this.btnPrintPreview, 3, 0);
            this.tblypnTop.Controls.Add(this.btnPrint, 1, 0);
            this.tblypnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnTop.Location = new System.Drawing.Point(0, 0);
            this.tblypnTop.Name = "tblypnTop";
            this.tblypnTop.RowCount = 1;
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnTop.Size = new System.Drawing.Size(1129, 51);
            this.tblypnTop.TabIndex = 2;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(679, 3);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(446, 45);
            this.btnPrintPreview.TabIndex = 4;
            this.btnPrintPreview.Text = "Print Preview Dialog";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "SampleA",
            "SampleB",
            "SampleC",
            "SampleD"});
            this.cmbModel.Location = new System.Drawing.Point(3, 3);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(254, 42);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.Text = "Sample Frame";
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(263, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 45);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDialog.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDialog.Location = new System.Drawing.Point(419, 3);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(254, 45);
            this.btnPrintDialog.TabIndex = 3;
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.UseVisualStyleBackColor = false;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // MedicalRecordWebViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 733);
            this.Controls.Add(this.pnBoss);
            this.Name = "MedicalRecordWebViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.MedicalRecordWebViewer_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMiddle.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.tblypnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Panel pnMiddle;
        private System.Windows.Forms.Panel pnTop;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.WebBrowser wvSampleA;
        private MedicalReportSampleA MedicalReportSampleA1;
        private MedicalReportSampleB MedicalReportSampleB1;
        private System.Windows.Forms.ComboBox cmbModel;
        private MedicalRecortSampleC MedicalRecortSampleC1;
        private MedicalRecortSampleD MedicalRecortSampleD1;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.TableLayoutPanel tblypnTop;
        private System.Windows.Forms.WebBrowser wvSampleB;
        private System.Windows.Forms.WebBrowser wvSampleD;
        private System.Windows.Forms.WebBrowser wvSampleC;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintDialog;
    }
}