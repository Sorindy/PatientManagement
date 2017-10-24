namespace PatientManagement
{
    partial class MedicalHistoryForm
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
            this.lbTodaydate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbMedicalRecord = new System.Windows.Forms.ComboBox();
            this.txtDescriptioinName = new System.Windows.Forms.TextBox();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.txtMedicalId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbPatient = new System.Windows.Forms.GroupBox();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dtgInformation = new System.Windows.Forms.DataGridView();
            this.btnFort = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.gbActivity.SuspendLayout();
            this.gbPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTodaydate
            // 
            this.lbTodaydate.AutoSize = true;
            this.lbTodaydate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodaydate.Location = new System.Drawing.Point(1025, 61);
            this.lbTodaydate.Name = "lbTodaydate";
            this.lbTodaydate.Size = new System.Drawing.Size(134, 25);
            this.lbTodaydate.TabIndex = 59;
            this.lbTodaydate.Text = "Today Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 33);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 33);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(9, 63);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(183, 33);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cmbMedicalRecord
            // 
            this.cmbMedicalRecord.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbMedicalRecord.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicalRecord.FormattingEnabled = true;
            this.cmbMedicalRecord.Items.AddRange(new object[] {
            "Consultation",
            "Prescription",
            "Medical Imaging",
            "Laboratory",
            "Variou Document"});
            this.cmbMedicalRecord.Location = new System.Drawing.Point(4, 226);
            this.cmbMedicalRecord.Name = "cmbMedicalRecord";
            this.cmbMedicalRecord.Size = new System.Drawing.Size(200, 26);
            this.cmbMedicalRecord.TabIndex = 60;
            this.cmbMedicalRecord.Text = "Medical-Record";
            this.cmbMedicalRecord.SelectedIndexChanged += new System.EventHandler(this.cmbMedicalRecord_SelectedIndexChanged);
            // 
            // txtDescriptioinName
            // 
            this.txtDescriptioinName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptioinName.Location = new System.Drawing.Point(713, 202);
            this.txtDescriptioinName.Name = "txtDescriptioinName";
            this.txtDescriptioinName.ReadOnly = true;
            this.txtDescriptioinName.Size = new System.Drawing.Size(333, 25);
            this.txtDescriptioinName.TabIndex = 58;
            this.txtDescriptioinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmTime
            // 
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // txtMedicalId
            // 
            this.txtMedicalId.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalId.Location = new System.Drawing.Point(368, 204);
            this.txtMedicalId.Name = "txtMedicalId";
            this.txtMedicalId.ReadOnly = true;
            this.txtMedicalId.Size = new System.Drawing.Size(197, 19);
            this.txtMedicalId.TabIndex = 65;
            this.txtMedicalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "Medical-History-Id";
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.btnUpdate);
            this.gbActivity.Controls.Add(this.btnClose);
            this.gbActivity.Controls.Add(this.btnClear);
            this.gbActivity.Controls.Add(this.btnPrint);
            this.gbActivity.Controls.Add(this.btnSubmit);
            this.gbActivity.Location = new System.Drawing.Point(12, 258);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(201, 194);
            this.gbActivity.TabIndex = 61;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activity";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 33);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 24);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 33);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(596, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Description";
            // 
            // gbPatient
            // 
            this.gbPatient.Controls.Add(this.btnPatientDetail);
            this.gbPatient.Controls.Add(this.txtPatientName);
            this.gbPatient.Controls.Add(this.txtPatientID);
            this.gbPatient.Controls.Add(this.label3);
            this.gbPatient.Controls.Add(this.label2);
            this.gbPatient.Location = new System.Drawing.Point(12, 61);
            this.gbPatient.Name = "gbPatient";
            this.gbPatient.Size = new System.Drawing.Size(294, 109);
            this.gbPatient.TabIndex = 52;
            this.gbPatient.TabStop = false;
            this.gbPatient.Text = "Patient Information";
            // 
            // btnPatientDetail
            // 
            this.btnPatientDetail.Location = new System.Drawing.Point(91, 79);
            this.btnPatientDetail.Name = "btnPatientDetail";
            this.btnPatientDetail.Size = new System.Drawing.Size(197, 20);
            this.btnPatientDetail.TabIndex = 5;
            this.btnPatientDetail.Text = "More Detail";
            this.btnPatientDetail.UseVisualStyleBackColor = true;
            this.btnPatientDetail.Click += new System.EventHandler(this.btnPatientDetail_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(91, 52);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(197, 19);
            this.txtPatientName.TabIndex = 3;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(91, 26);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(197, 19);
            this.txtPatientID.TabIndex = 2;
            this.txtPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 36);
            this.label1.TabIndex = 51;
            this.label1.Text = "Medical History Form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Medical-Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(315, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 109);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(106, 76);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(197, 21);
            this.cmbCategory.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doctor-Category";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(106, 52);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(197, 19);
            this.txtStaffName.TabIndex = 7;
            this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(106, 26);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(197, 19);
            this.txtStaffID.TabIndex = 6;
            this.txtStaffID.Text = "Worker1";
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor-Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor-Id";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 1325;
            this.lineShape1.Y1 = 179;
            this.lineShape1.Y2 = 179;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 219;
            this.lineShape2.X2 = 219;
            this.lineShape2.Y1 = 180;
            this.lineShape2.Y2 = 729;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1328, 733);
            this.shapeContainer1.TabIndex = 69;
            this.shapeContainer1.TabStop = false;
            // 
            // dtgInformation
            // 
            this.dtgInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInformation.Location = new System.Drawing.Point(243, 233);
            this.dtgInformation.Name = "dtgInformation";
            this.dtgInformation.Size = new System.Drawing.Size(1082, 488);
            this.dtgInformation.TabIndex = 70;
            this.dtgInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInformation_CellContentClick);
            // 
            // btnFort
            // 
            this.btnFort.Location = new System.Drawing.Point(1065, 204);
            this.btnFort.Name = "btnFort";
            this.btnFort.Size = new System.Drawing.Size(82, 23);
            this.btnFort.TabIndex = 71;
            this.btnFort.Text = "Font";
            this.btnFort.UseVisualStyleBackColor = true;
            this.btnFort.Click += new System.EventHandler(this.btnFort_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(244, 233);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1082, 488);
            this.txtDescription.TabIndex = 72;
            this.txtDescription.Text = "";
            // 
            // MedicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 733);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnFort);
            this.Controls.Add(this.dtgInformation);
            this.Controls.Add(this.lbTodaydate);
            this.Controls.Add(this.cmbMedicalRecord);
            this.Controls.Add(this.txtDescriptioinName);
            this.Controls.Add(this.txtMedicalId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbActivity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MedicalHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalHistoryForm";
            this.Load += new System.EventHandler(this.MedicalHistoryForm_Load);
            this.gbActivity.ResumeLayout(false);
            this.gbPatient.ResumeLayout(false);
            this.gbPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTodaydate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbMedicalRecord;
        private System.Windows.Forms.TextBox txtDescriptioinName;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.TextBox txtMedicalId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbPatient;
        private System.Windows.Forms.Button btnPatientDetail;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView dtgInformation;
        private System.Windows.Forms.Button btnFort;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnUpdate;
    }
}