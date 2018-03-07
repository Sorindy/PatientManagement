namespace PatientManagement
{
    partial class CatelogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatelogForm));
            this.pnlMainLeft = new System.Windows.Forms.Panel();
            this.pnlLeftFill = new System.Windows.Forms.Panel();
            this.pnlLeftbuttom = new System.Windows.Forms.Panel();
            this.tblClose = new System.Windows.Forms.TableLayoutPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbClose = new System.Windows.Forms.Label();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.tblpanelLeftMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblpanelPicture = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainLeft.SuspendLayout();
            this.pnlLeftbuttom.SuspendLayout();
            this.tblClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            this.tblpanelLeftMain.SuspendLayout();
            this.tblpanelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLeft
            // 
            this.pnlMainLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMainLeft.Controls.Add(this.pnlLeftFill);
            this.pnlMainLeft.Controls.Add(this.pnlLeftbuttom);
            this.pnlMainLeft.Controls.Add(this.pnlLeftTop);
            this.pnlMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainLeft.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainLeft.Name = "pnlMainLeft";
            this.pnlMainLeft.Size = new System.Drawing.Size(225, 729);
            this.pnlMainLeft.TabIndex = 0;
            // 
            // pnlLeftFill
            // 
            this.pnlLeftFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeftFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftFill.Location = new System.Drawing.Point(0, 157);
            this.pnlLeftFill.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftFill.Name = "pnlLeftFill";
            this.pnlLeftFill.Size = new System.Drawing.Size(225, 510);
            this.pnlLeftFill.TabIndex = 3;
            // 
            // pnlLeftbuttom
            // 
            this.pnlLeftbuttom.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlLeftbuttom.Controls.Add(this.tblClose);
            this.pnlLeftbuttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLeftbuttom.Location = new System.Drawing.Point(0, 667);
            this.pnlLeftbuttom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftbuttom.Name = "pnlLeftbuttom";
            this.pnlLeftbuttom.Size = new System.Drawing.Size(225, 62);
            this.pnlLeftbuttom.TabIndex = 2;
            // 
            // tblClose
            // 
            this.tblClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.tblClose.ColumnCount = 2;
            this.tblClose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46296F));
            this.tblClose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53704F));
            this.tblClose.Controls.Add(this.picClose, 0, 0);
            this.tblClose.Controls.Add(this.lbClose, 1, 0);
            this.tblClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblClose.Location = new System.Drawing.Point(0, 0);
            this.tblClose.Margin = new System.Windows.Forms.Padding(4);
            this.tblClose.Name = "tblClose";
            this.tblClose.RowCount = 1;
            this.tblClose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblClose.Size = new System.Drawing.Size(225, 62);
            this.tblClose.TabIndex = 0;
            this.tblClose.Click += new System.EventHandler(this.tblClose_Click);
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(4, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(49, 54);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbClose
            // 
            this.lbClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbClose.AutoSize = true;
            this.lbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbClose.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.Tomato;
            this.lbClose.Location = new System.Drawing.Point(70, 7);
            this.lbClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(141, 48);
            this.lbClose.TabIndex = 0;
            this.lbClose.Text = "Close";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlLeftTop.Controls.Add(this.tblpanelLeftMain);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(225, 157);
            this.pnlLeftTop.TabIndex = 1;
            // 
            // tblpanelLeftMain
            // 
            this.tblpanelLeftMain.ColumnCount = 1;
            this.tblpanelLeftMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpanelLeftMain.Controls.Add(this.tblpanelPicture, 0, 0);
            this.tblpanelLeftMain.Controls.Add(this.txtUserName, 0, 1);
            this.tblpanelLeftMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpanelLeftMain.Location = new System.Drawing.Point(0, 0);
            this.tblpanelLeftMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblpanelLeftMain.Name = "tblpanelLeftMain";
            this.tblpanelLeftMain.RowCount = 2;
            this.tblpanelLeftMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.31258F));
            this.tblpanelLeftMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68742F));
            this.tblpanelLeftMain.Size = new System.Drawing.Size(225, 157);
            this.tblpanelLeftMain.TabIndex = 3;
            // 
            // tblpanelPicture
            // 
            this.tblpanelPicture.ColumnCount = 3;
            this.tblpanelPicture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.63415F));
            this.tblpanelPicture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.36585F));
            this.tblpanelPicture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblpanelPicture.Controls.Add(this.panelLogout, 2, 0);
            this.tblpanelPicture.Controls.Add(this.pictureBox1, 1, 0);
            this.tblpanelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpanelPicture.Location = new System.Drawing.Point(4, 4);
            this.tblpanelPicture.Margin = new System.Windows.Forms.Padding(4);
            this.tblpanelPicture.Name = "tblpanelPicture";
            this.tblpanelPicture.RowCount = 1;
            this.tblpanelPicture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpanelPicture.Size = new System.Drawing.Size(217, 111);
            this.tblpanelPicture.TabIndex = 0;
            // 
            // panelLogout
            // 
            this.panelLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogout.BackgroundImage")));
            this.panelLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogout.Location = new System.Drawing.Point(177, 4);
            this.panelLogout.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(36, 40);
            this.panelLogout.TabIndex = 1;
            this.panelLogout.Click += new System.EventHandler(this.panelLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(70, 128);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(85, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "UserName";
            // 
            // pnlFill
            // 
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(225, 48);
            this.pnlFill.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1129, 681);
            this.pnlFill.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlTop.Controls.Add(this.tableLayoutPanel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(225, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1129, 48);
            this.pnlTop.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.70946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblDatetime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // lblDatetime
            // 
            this.lblDatetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.Location = new System.Drawing.Point(352, 0);
            this.lblDatetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(226, 48);
            this.lblDatetime.TabIndex = 3;
            this.lblDatetime.Text = "DateTime";
            this.lblDatetime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDatetime_MouseDown);
            this.lblDatetime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDatetime_MouseMove);
            this.lblDatetime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDatetime_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CatelogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMainLeft);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatelogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient\'s Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatelogForm_FormClosed);
            this.Shown += new System.EventHandler(this.CatelogForm_Shown);
            this.pnlMainLeft.ResumeLayout(false);
            this.pnlLeftbuttom.ResumeLayout(false);
            this.tblClose.ResumeLayout(false);
            this.tblClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.tblpanelLeftMain.ResumeLayout(false);
            this.tblpanelLeftMain.PerformLayout();
            this.tblpanelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLeft;
        private System.Windows.Forms.Panel pnlLeftFill;
        private System.Windows.Forms.Panel pnlLeftbuttom;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.TableLayoutPanel tblpanelLeftMain;
        private System.Windows.Forms.TableLayoutPanel tblpanelPicture;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.TableLayoutPanel tblClose;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}