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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripcmbModel = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsDefaultPrintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtATop = new System.Windows.Forms.ToolStripTextBox();
            this.txtAleft = new System.Windows.Forms.ToolStripTextBox();
            this.txtARight = new System.Windows.Forms.ToolStripTextBox();
            this.txtADown = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setAAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBTop = new System.Windows.Forms.ToolStripTextBox();
            this.txtBLeft = new System.Windows.Forms.ToolStripTextBox();
            this.txtBRight = new System.Windows.Forms.ToolStripTextBox();
            this.txtBDown = new System.Windows.Forms.ToolStripTextBox();
            this.setBAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCTop = new System.Windows.Forms.ToolStripTextBox();
            this.txtCLeft = new System.Windows.Forms.ToolStripTextBox();
            this.txtCRight = new System.Windows.Forms.ToolStripTextBox();
            this.txtCDown = new System.Windows.Forms.ToolStripTextBox();
            this.setCAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDTop = new System.Windows.Forms.ToolStripTextBox();
            this.txtDLeft = new System.Windows.Forms.ToolStripTextBox();
            this.txtDRight = new System.Windows.Forms.ToolStripTextBox();
            this.txtDDown = new System.Windows.Forms.ToolStripTextBox();
            this.setDAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnBoss.Size = new System.Drawing.Size(1284, 961);
            this.pnBoss.TabIndex = 1;
            // 
            // pnMiddle
            // 
            this.pnMiddle.Controls.Add(this.wvPrintSample);
            this.pnMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMiddle.Location = new System.Drawing.Point(0, 51);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(1284, 910);
            this.pnMiddle.TabIndex = 2;
            // 
            // wvPrintSample
            // 
            this.wvPrintSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPrintSample.Location = new System.Drawing.Point(0, 0);
            this.wvPrintSample.Margin = new System.Windows.Forms.Padding(0);
            this.wvPrintSample.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvPrintSample.Name = "wvPrintSample";
            this.wvPrintSample.Size = new System.Drawing.Size(1284, 910);
            this.wvPrintSample.TabIndex = 1;
            this.wvPrintSample.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wvPrintSample_Navigated);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.menuStrip1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1284, 51);
            this.pnTop.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(1284, 51);
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
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.setAsDefaultPrintToolStripMenuItem1.Name = "setAsDefaultPrintToolStripMenuItem1";
            this.setAsDefaultPrintToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.setAsDefaultPrintToolStripMenuItem1.Text = "Set As Default Print";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtATop,
            this.txtAleft,
            this.txtARight,
            this.txtADown,
            this.toolStripSeparator1,
            this.setAAsDefaultToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem1.Text = "A (Top,Left,Right,Down)";
            this.toolStripMenuItem1.MouseEnter += new System.EventHandler(this.toolStripMenuItem1_MouseEnter);
            // 
            // txtATop
            // 
            this.txtATop.Name = "txtATop";
            this.txtATop.Size = new System.Drawing.Size(100, 23);
            this.txtATop.Text = "top";
            this.txtATop.Click += new System.EventHandler(this.txtATop_Click);
            this.txtATop.MouseEnter += new System.EventHandler(this.txtATop_Click);
            // 
            // txtAleft
            // 
            this.txtAleft.Name = "txtAleft";
            this.txtAleft.Size = new System.Drawing.Size(100, 23);
            this.txtAleft.Text = "left";
            this.txtAleft.Click += new System.EventHandler(this.txtAleft_Click);
            this.txtAleft.MouseEnter += new System.EventHandler(this.txtAleft_Click);
            // 
            // txtARight
            // 
            this.txtARight.Name = "txtARight";
            this.txtARight.Size = new System.Drawing.Size(100, 23);
            this.txtARight.Text = "right";
            this.txtARight.Click += new System.EventHandler(this.txtARight_Click);
            this.txtARight.MouseEnter += new System.EventHandler(this.txtARight_Click);
            // 
            // txtADown
            // 
            this.txtADown.Name = "txtADown";
            this.txtADown.Size = new System.Drawing.Size(100, 23);
            this.txtADown.Text = "down";
            this.txtADown.Click += new System.EventHandler(this.txtADown_Click);
            this.txtADown.MouseEnter += new System.EventHandler(this.txtADown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // setAAsDefaultToolStripMenuItem
            // 
            this.setAAsDefaultToolStripMenuItem.Name = "setAAsDefaultToolStripMenuItem";
            this.setAAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setAAsDefaultToolStripMenuItem.Text = "Set A as Default";
            this.setAAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.setAAsDefaultToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBTop,
            this.txtBLeft,
            this.txtBRight,
            this.txtBDown,
            this.setBAsDefaultToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem2.Text = "B (Top,Left,Right,Down)";
            this.toolStripMenuItem2.MouseEnter += new System.EventHandler(this.toolStripMenuItem2_MouseEnter);
            // 
            // txtBTop
            // 
            this.txtBTop.Name = "txtBTop";
            this.txtBTop.Size = new System.Drawing.Size(100, 23);
            this.txtBTop.Text = "top";
            this.txtBTop.MouseEnter += new System.EventHandler(this.txtBTop_MouseEnter);
            // 
            // txtBLeft
            // 
            this.txtBLeft.Name = "txtBLeft";
            this.txtBLeft.Size = new System.Drawing.Size(100, 23);
            this.txtBLeft.Text = "left";
            this.txtBLeft.MouseEnter += new System.EventHandler(this.txtBLeft_MouseEnter);
            // 
            // txtBRight
            // 
            this.txtBRight.Name = "txtBRight";
            this.txtBRight.Size = new System.Drawing.Size(100, 23);
            this.txtBRight.Text = "right";
            this.txtBRight.MouseEnter += new System.EventHandler(this.txtBRight_MouseEnter);
            // 
            // txtBDown
            // 
            this.txtBDown.Name = "txtBDown";
            this.txtBDown.Size = new System.Drawing.Size(100, 23);
            this.txtBDown.Text = "down";
            this.txtBDown.MouseEnter += new System.EventHandler(this.txtBDown_MouseEnter);
            // 
            // setBAsDefaultToolStripMenuItem
            // 
            this.setBAsDefaultToolStripMenuItem.Name = "setBAsDefaultToolStripMenuItem";
            this.setBAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setBAsDefaultToolStripMenuItem.Text = "Set B as Default";
            this.setBAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.setBAsDefaultToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtCTop,
            this.txtCLeft,
            this.txtCRight,
            this.txtCDown,
            this.setCAsDefaultToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem3.Text = "C (Top,Left,Right,Down)";
            this.toolStripMenuItem3.MouseEnter += new System.EventHandler(this.toolStripMenuItem3_MouseEnter);
            // 
            // txtCTop
            // 
            this.txtCTop.Name = "txtCTop";
            this.txtCTop.Size = new System.Drawing.Size(100, 23);
            this.txtCTop.Text = "top";
            this.txtCTop.MouseEnter += new System.EventHandler(this.txtCTop_MouseEnter);
            // 
            // txtCLeft
            // 
            this.txtCLeft.Name = "txtCLeft";
            this.txtCLeft.Size = new System.Drawing.Size(100, 23);
            this.txtCLeft.Text = "left";
            this.txtCLeft.MouseEnter += new System.EventHandler(this.txtCLeft_MouseEnter);
            // 
            // txtCRight
            // 
            this.txtCRight.Name = "txtCRight";
            this.txtCRight.Size = new System.Drawing.Size(100, 23);
            this.txtCRight.Text = "right";
            this.txtCRight.MouseEnter += new System.EventHandler(this.txtCRight_MouseEnter);
            // 
            // txtCDown
            // 
            this.txtCDown.Name = "txtCDown";
            this.txtCDown.Size = new System.Drawing.Size(100, 23);
            this.txtCDown.Text = "down";
            this.txtCDown.MouseEnter += new System.EventHandler(this.txtCDown_MouseEnter);
            // 
            // setCAsDefaultToolStripMenuItem
            // 
            this.setCAsDefaultToolStripMenuItem.Name = "setCAsDefaultToolStripMenuItem";
            this.setCAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setCAsDefaultToolStripMenuItem.Text = "Set C as Default";
            this.setCAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.setCAsDefaultToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDTop,
            this.txtDLeft,
            this.txtDRight,
            this.txtDDown,
            this.setDAsDefaultToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem4.Text = "D (Top,Left,Right,Down)";
            this.toolStripMenuItem4.MouseEnter += new System.EventHandler(this.toolStripMenuItem4_MouseEnter);
            // 
            // txtDTop
            // 
            this.txtDTop.Name = "txtDTop";
            this.txtDTop.Size = new System.Drawing.Size(100, 23);
            this.txtDTop.Text = "top";
            this.txtDTop.MouseEnter += new System.EventHandler(this.txtDTop_MouseEnter);
            // 
            // txtDLeft
            // 
            this.txtDLeft.Name = "txtDLeft";
            this.txtDLeft.Size = new System.Drawing.Size(100, 23);
            this.txtDLeft.Text = "left";
            this.txtDLeft.MouseEnter += new System.EventHandler(this.txtDLeft_MouseEnter);
            // 
            // txtDRight
            // 
            this.txtDRight.Name = "txtDRight";
            this.txtDRight.Size = new System.Drawing.Size(100, 23);
            this.txtDRight.Text = "right";
            this.txtDRight.MouseEnter += new System.EventHandler(this.txtDRight_MouseEnter);
            // 
            // txtDDown
            // 
            this.txtDDown.Name = "txtDDown";
            this.txtDDown.Size = new System.Drawing.Size(100, 23);
            this.txtDDown.Text = "down";
            this.txtDDown.MouseEnter += new System.EventHandler(this.txtDDown_MouseEnter);
            // 
            // setDAsDefaultToolStripMenuItem
            // 
            this.setDAsDefaultToolStripMenuItem.Name = "setDAsDefaultToolStripMenuItem";
            this.setDAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setDAsDefaultToolStripMenuItem.Text = "Set D as Default";
            this.setDAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.setDAsDefaultToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(1284, 961);
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
        private System.Windows.Forms.WebBrowser wvPrintSample;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txtATop;
        private System.Windows.Forms.ToolStripTextBox txtAleft;
        private System.Windows.Forms.ToolStripTextBox txtARight;
        private System.Windows.Forms.ToolStripTextBox txtADown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setAAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox txtBTop;
        private System.Windows.Forms.ToolStripTextBox txtBLeft;
        private System.Windows.Forms.ToolStripTextBox txtBRight;
        private System.Windows.Forms.ToolStripTextBox txtBDown;
        private System.Windows.Forms.ToolStripMenuItem setBAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtCTop;
        private System.Windows.Forms.ToolStripTextBox txtCLeft;
        private System.Windows.Forms.ToolStripTextBox txtCRight;
        private System.Windows.Forms.ToolStripTextBox txtCDown;
        private System.Windows.Forms.ToolStripMenuItem setCAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtDTop;
        private System.Windows.Forms.ToolStripTextBox txtDLeft;
        private System.Windows.Forms.ToolStripTextBox txtDRight;
        private System.Windows.Forms.ToolStripTextBox txtDDown;
        private System.Windows.Forms.ToolStripMenuItem setDAsDefaultToolStripMenuItem;
    }
}