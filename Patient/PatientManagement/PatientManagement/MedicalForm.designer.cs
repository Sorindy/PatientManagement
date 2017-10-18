﻿namespace PatientManagement
{
    partial class MedicalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPatient = new System.Windows.Forms.GroupBox();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMedicalHistory = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescriptioinName = new System.Windows.Forms.TextBox();
            this.lbTodaydate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbMedicalRecord = new System.Windows.Forms.ComboBox();
            this.btnDatinglist = new System.Windows.Forms.Button();
            this.btnWaitinglist = new System.Windows.Forms.Button();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.gbDating_waiting = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gbDating = new System.Windows.Forms.GroupBox();
            this.btnAddDating = new System.Windows.Forms.Button();
            this.dtpDating = new System.Windows.Forms.DateTimePicker();
            this.tmDate = new System.Windows.Forms.Timer(this.components);
            this.txtMedicalId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSample = new System.Windows.Forms.ComboBox();
            this.btnFort = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.gbMedicalItem = new System.Windows.Forms.GroupBox();
            this.gbPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbActivity.SuspendLayout();
            this.gbDating_waiting.SuspendLayout();
            this.gbDating.SuspendLayout();
            this.gbMedicalItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical Form";
            // 
            // gbPatient
            // 
            this.gbPatient.Controls.Add(this.btnPatientDetail);
            this.gbPatient.Controls.Add(this.txtPatientName);
            this.gbPatient.Controls.Add(this.txtPatientID);
            this.gbPatient.Controls.Add(this.label3);
            this.gbPatient.Controls.Add(this.label2);
            this.gbPatient.Location = new System.Drawing.Point(7, 64);
            this.gbPatient.Name = "gbPatient";
            this.gbPatient.Size = new System.Drawing.Size(294, 109);
            this.gbPatient.TabIndex = 1;
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
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1328, 733);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = -1;
            this.lineShape6.X2 = 214;
            this.lineShape6.Y1 = 542;
            this.lineShape6.Y2 = 542;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 0;
            this.lineShape5.X2 = 215;
            this.lineShape5.Y1 = 650;
            this.lineShape5.Y2 = 650;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 0;
            this.lineShape3.X2 = 215;
            this.lineShape3.Y1 = 292;
            this.lineShape3.Y2 = 292;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 215;
            this.lineShape2.X2 = 215;
            this.lineShape2.Y1 = 187;
            this.lineShape2.Y2 = 736;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 3;
            this.lineShape1.X2 = 1321;
            this.lineShape1.Y1 = 186;
            this.lineShape1.Y2 = 186;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(310, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "ConsultationCategory1",
            "ConsultationCategory2",
            "LaboratoryCategory1",
            "PrescriptionCategory1"});
            this.cmbCategory.Location = new System.Drawing.Point(106, 76);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(197, 21);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
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
            // btnMedicalHistory
            // 
            this.btnMedicalHistory.Location = new System.Drawing.Point(9, 25);
            this.btnMedicalHistory.Name = "btnMedicalHistory";
            this.btnMedicalHistory.Size = new System.Drawing.Size(183, 28);
            this.btnMedicalHistory.TabIndex = 4;
            this.btnMedicalHistory.Text = "Medical History";
            this.btnMedicalHistory.UseVisualStyleBackColor = true;
            this.btnMedicalHistory.Click += new System.EventHandler(this.btnMedicalHistory_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 34);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 33);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Summit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Description";
            // 
            // txtDescriptioinName
            // 
            this.txtDescriptioinName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptioinName.Location = new System.Drawing.Point(347, 203);
            this.txtDescriptioinName.Name = "txtDescriptioinName";
            this.txtDescriptioinName.ReadOnly = true;
            this.txtDescriptioinName.Size = new System.Drawing.Size(333, 25);
            this.txtDescriptioinName.TabIndex = 17;
            this.txtDescriptioinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTodaydate
            // 
            this.lbTodaydate.AutoSize = true;
            this.lbTodaydate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodaydate.Location = new System.Drawing.Point(1020, 64);
            this.lbTodaydate.Name = "lbTodaydate";
            this.lbTodaydate.Size = new System.Drawing.Size(134, 25);
            this.lbTodaydate.TabIndex = 19;
            this.lbTodaydate.Text = "Today Date";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(9, 112);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(183, 33);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 33);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 33);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(183, 33);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.cmbMedicalRecord.Location = new System.Drawing.Point(9, 59);
            this.cmbMedicalRecord.Name = "cmbMedicalRecord";
            this.cmbMedicalRecord.Size = new System.Drawing.Size(183, 26);
            this.cmbMedicalRecord.TabIndex = 41;
            this.cmbMedicalRecord.Text = "Medical-Record";
            this.cmbMedicalRecord.SelectedIndexChanged += new System.EventHandler(this.cmbMedicalRecord_SelectedIndexChanged);
            // 
            // btnDatinglist
            // 
            this.btnDatinglist.Location = new System.Drawing.Point(6, 19);
            this.btnDatinglist.Name = "btnDatinglist";
            this.btnDatinglist.Size = new System.Drawing.Size(183, 33);
            this.btnDatinglist.TabIndex = 42;
            this.btnDatinglist.Text = "Dating-List";
            this.btnDatinglist.UseVisualStyleBackColor = true;
            this.btnDatinglist.Click += new System.EventHandler(this.btnDatinglist_Click);
            // 
            // btnWaitinglist
            // 
            this.btnWaitinglist.Location = new System.Drawing.Point(6, 58);
            this.btnWaitinglist.Name = "btnWaitinglist";
            this.btnWaitinglist.Size = new System.Drawing.Size(183, 33);
            this.btnWaitinglist.TabIndex = 43;
            this.btnWaitinglist.Text = "Wating-List";
            this.btnWaitinglist.UseVisualStyleBackColor = true;
            this.btnWaitinglist.Click += new System.EventHandler(this.btnWaitinglist_Click);
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.btnClose);
            this.gbActivity.Controls.Add(this.btnNew);
            this.gbActivity.Controls.Add(this.btnClear);
            this.gbActivity.Controls.Add(this.btnPrint);
            this.gbActivity.Controls.Add(this.btnSubmit);
            this.gbActivity.Controls.Add(this.btnUpdate);
            this.gbActivity.Location = new System.Drawing.Point(7, 303);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(201, 237);
            this.gbActivity.TabIndex = 44;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activity";
            // 
            // gbDating_waiting
            // 
            this.gbDating_waiting.Controls.Add(this.btnDatinglist);
            this.gbDating_waiting.Controls.Add(this.btnWaitinglist);
            this.gbDating_waiting.Controls.Add(this.shapeContainer2);
            this.gbDating_waiting.Location = new System.Drawing.Point(7, 546);
            this.gbDating_waiting.Name = "gbDating_waiting";
            this.gbDating_waiting.Size = new System.Drawing.Size(200, 100);
            this.gbDating_waiting.TabIndex = 45;
            this.gbDating_waiting.TabStop = false;
            this.gbDating_waiting.Text = "Patient-List";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(194, 81);
            this.shapeContainer2.TabIndex = 44;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -9;
            this.lineShape4.X2 = 206;
            this.lineShape4.Y1 = -17;
            this.lineShape4.Y2 = -17;
            // 
            // gbDating
            // 
            this.gbDating.Controls.Add(this.btnAddDating);
            this.gbDating.Controls.Add(this.dtpDating);
            this.gbDating.Location = new System.Drawing.Point(7, 652);
            this.gbDating.Name = "gbDating";
            this.gbDating.Size = new System.Drawing.Size(201, 78);
            this.gbDating.TabIndex = 46;
            this.gbDating.TabStop = false;
            this.gbDating.Text = "Dating-Patient";
            // 
            // btnAddDating
            // 
            this.btnAddDating.Location = new System.Drawing.Point(123, 30);
            this.btnAddDating.Name = "btnAddDating";
            this.btnAddDating.Size = new System.Drawing.Size(74, 22);
            this.btnAddDating.TabIndex = 44;
            this.btnAddDating.Text = "Add";
            this.btnAddDating.UseVisualStyleBackColor = true;
            this.btnAddDating.Click += new System.EventHandler(this.btnAddDating_Click);
            // 
            // dtpDating
            // 
            this.dtpDating.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDating.Location = new System.Drawing.Point(9, 32);
            this.dtpDating.Name = "dtpDating";
            this.dtpDating.Size = new System.Drawing.Size(113, 20);
            this.dtpDating.TabIndex = 0;
            // 
            // tmDate
            // 
            this.tmDate.Tick += new System.EventHandler(this.tmDate_Tick);
            // 
            // txtMedicalId
            // 
            this.txtMedicalId.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalId.Location = new System.Drawing.Point(347, 209);
            this.txtMedicalId.Name = "txtMedicalId";
            this.txtMedicalId.ReadOnly = true;
            this.txtMedicalId.Size = new System.Drawing.Size(197, 19);
            this.txtMedicalId.TabIndex = 48;
            this.txtMedicalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedicalId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Medical-Id";
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(687, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Sample";
            // 
            // cmbSample
            // 
            this.cmbSample.FormattingEnabled = true;
            this.cmbSample.Location = new System.Drawing.Point(744, 208);
            this.cmbSample.Name = "cmbSample";
            this.cmbSample.Size = new System.Drawing.Size(197, 21);
            this.cmbSample.TabIndex = 50;
            this.cmbSample.SelectedIndexChanged += new System.EventHandler(this.cmbSample_SelectedIndexChanged);
            // 
            // btnFort
            // 
            this.btnFort.Location = new System.Drawing.Point(944, 207);
            this.btnFort.Name = "btnFort";
            this.btnFort.Size = new System.Drawing.Size(82, 23);
            this.btnFort.TabIndex = 51;
            this.btnFort.Text = "Font";
            this.btnFort.UseVisualStyleBackColor = true;
            this.btnFort.Click += new System.EventHandler(this.btnFort_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(234, 233);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1082, 488);
            this.txtDescription.TabIndex = 52;
            this.txtDescription.Text = "";
            // 
            // gbMedicalItem
            // 
            this.gbMedicalItem.Controls.Add(this.btnMedicalHistory);
            this.gbMedicalItem.Controls.Add(this.cmbMedicalRecord);
            this.gbMedicalItem.Location = new System.Drawing.Point(7, 193);
            this.gbMedicalItem.Name = "gbMedicalItem";
            this.gbMedicalItem.Size = new System.Drawing.Size(200, 91);
            this.gbMedicalItem.TabIndex = 53;
            this.gbMedicalItem.TabStop = false;
            this.gbMedicalItem.Text = "Medical-Item";
            // 
            // MedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 733);
            this.Controls.Add(this.gbMedicalItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnFort);
            this.Controls.Add(this.cmbSample);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMedicalId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbDating);
            this.Controls.Add(this.gbDating_waiting);
            this.Controls.Add(this.gbActivity);
            this.Controls.Add(this.lbTodaydate);
            this.Controls.Add(this.txtDescriptioinName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MedicalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalForm";
            this.Load += new System.EventHandler(this.MedicalForm_Load);
            this.gbPatient.ResumeLayout(false);
            this.gbPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbActivity.ResumeLayout(false);
            this.gbDating_waiting.ResumeLayout(false);
            this.gbDating.ResumeLayout(false);
            this.gbMedicalItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button btnMedicalHistory;
        private System.Windows.Forms.Button btnPatientDetail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescriptioinName;
        private System.Windows.Forms.Label lbTodaydate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbMedicalRecord;
        private System.Windows.Forms.Button btnDatinglist;
        private System.Windows.Forms.Button btnWaitinglist;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.GroupBox gbDating_waiting;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.GroupBox gbDating;
        private System.Windows.Forms.Button btnAddDating;
        private System.Windows.Forms.DateTimePicker dtpDating;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Timer tmDate;
        private System.Windows.Forms.TextBox txtMedicalId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSample;
        private System.Windows.Forms.Button btnFort;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.GroupBox gbMedicalItem;
        internal System.Windows.Forms.TextBox txtPatientName;
        internal System.Windows.Forms.TextBox txtPatientID;
    }
}