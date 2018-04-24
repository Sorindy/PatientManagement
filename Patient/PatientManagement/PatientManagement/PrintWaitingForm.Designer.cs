namespace PatientManagement
{
    partial class PrintWaitingForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripLabel();
            this.btnPrintDialog = new System.Windows.Forms.ToolStripLabel();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripLabel();
            this.wvPrint = new System.Windows.Forms.WebBrowser();
            this.pnBoss.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.wvPrint);
            this.pnBoss.Controls.Add(this.toolStrip1);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1264, 729);
            this.pnBoss.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrintDialog,
            this.btnPrintPreview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(69, 22);
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(76, 22);
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // wvPrint
            // 
            this.wvPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPrint.Location = new System.Drawing.Point(0, 25);
            this.wvPrint.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvPrint.Name = "wvPrint";
            this.wvPrint.Size = new System.Drawing.Size(1264, 704);
            this.wvPrint.TabIndex = 1;
            this.wvPrint.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wvPrint_Navigated);
            // 
            // PrintWaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.pnBoss);
            this.Name = "PrintWaitingForm";
            this.Text = "PrintWaitingForm";
            this.Load += new System.EventHandler(this.PrintWaitingForm_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnBoss.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnPrint;
        private System.Windows.Forms.ToolStripLabel btnPrintDialog;
        private System.Windows.Forms.ToolStripLabel btnPrintPreview;
        private System.Windows.Forms.WebBrowser wvPrint;

    }
}