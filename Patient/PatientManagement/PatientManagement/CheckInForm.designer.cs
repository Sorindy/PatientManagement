namespace PatientManagement
{
    partial class CheckInForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvShowPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch4Patient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gboService = new System.Windows.Forms.GroupBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchDating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvShowDatingPatient = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSearchDating = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gboCategory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDatingPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 652);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 57);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvShowPatient
            // 
            this.dgvShowPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowPatient.Location = new System.Drawing.Point(12, 175);
            this.dgvShowPatient.Name = "dgvShowPatient";
            this.dgvShowPatient.Size = new System.Drawing.Size(635, 163);
            this.dgvShowPatient.TabIndex = 1;
            this.dgvShowPatient.SelectionChanged += new System.EventHandler(this.dgvShowPatient_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Check-In";
            // 
            // txtSearch4Patient
            // 
            this.txtSearch4Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch4Patient.Location = new System.Drawing.Point(152, 123);
            this.txtSearch4Patient.Name = "txtSearch4Patient";
            this.txtSearch4Patient.Size = new System.Drawing.Size(306, 27);
            this.txtSearch4Patient.TabIndex = 3;
            this.txtSearch4Patient.TextChanged += new System.EventHandler(this.txtSearch4Patient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search";
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(21, 552);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(160, 57);
            this.btnNewPatient.TabIndex = 9;
            this.btnNewPatient.Text = "NEW";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(327, 552);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 57);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gboService
            // 
            this.gboService.Location = new System.Drawing.Point(664, 109);
            this.gboService.Name = "gboService";
            this.gboService.Size = new System.Drawing.Size(680, 100);
            this.gboService.TabIndex = 11;
            this.gboService.TabStop = false;
            this.gboService.Text = "Service";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(511, 109);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(124, 44);
            this.btnSearchPatient.TabIndex = 12;
            this.btnSearchPatient.Text = "SEARCH";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search";
            // 
            // txtSearchDating
            // 
            this.txtSearchDating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDating.Location = new System.Drawing.Point(152, 344);
            this.txtSearchDating.Name = "txtSearchDating";
            this.txtSearchDating.Size = new System.Drawing.Size(306, 27);
            this.txtSearchDating.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Patient List";
            // 
            // dgvShowDatingPatient
            // 
            this.dgvShowDatingPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowDatingPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDatingPatient.Location = new System.Drawing.Point(12, 389);
            this.dgvShowDatingPatient.Name = "dgvShowDatingPatient";
            this.dgvShowDatingPatient.Size = new System.Drawing.Size(635, 138);
            this.dgvShowDatingPatient.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dating List";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(327, 652);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(160, 57);
            this.btnPreview.TabIndex = 18;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Minerva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1031, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 34);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Time";
            // 
            // btnSearchDating
            // 
            this.btnSearchDating.Location = new System.Drawing.Point(511, 344);
            this.btnSearchDating.Name = "btnSearchDating";
            this.btnSearchDating.Size = new System.Drawing.Size(124, 38);
            this.btnSearchDating.TabIndex = 20;
            this.btnSearchDating.Text = "SEARCH";
            this.btnSearchDating.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gboCategory
            // 
            this.gboCategory.Location = new System.Drawing.Point(664, 239);
            this.gboCategory.Name = "gboCategory";
            this.gboCategory.Size = new System.Drawing.Size(680, 407);
            this.gboCategory.TabIndex = 0;
            this.gboCategory.TabStop = false;
            this.gboCategory.Text = "Category";
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.ControlBox = false;
            this.Controls.Add(this.gboCategory);
            this.Controls.Add(this.btnSearchDating);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvShowDatingPatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchDating);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.gboService);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch4Patient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowPatient);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDatingPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvShowPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch4Patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gboService;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchDating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvShowDatingPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSearchDating;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.GroupBox gboCategory;
    }
}