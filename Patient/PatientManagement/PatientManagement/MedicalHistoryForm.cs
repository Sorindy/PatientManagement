﻿using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class MedicalHistoryForm : Form
    {

        private MedicalHistory _medicalHistory = new MedicalHistory();

        public string PatientIdTextboxChange 
        {
            get { return txtPatientID.Text; }
            set { txtPatientID.Text = value; }
        }


        public MedicalHistoryForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Hide();
            var mediccalform = new MedicalForm();
            mediccalform.Show();
            Refresh();
            
        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {
            tmTime.Start();
            dtgInformation.Visible = false;
            txtMedicalId.Text = _medicalHistory.Show_medicalhistory(txtPatientID.Text).Id;
            txtDescription.Text = _medicalHistory.Show_medicalhistory(txtPatientID.Text).Description;
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
            if (txtMedicalId.Text == "")
            {
               txtMedicalId.Text = _medicalHistory.AutoId();
                btnSubmit.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = Convert.ToString(DateTime.Now);
        }

        private void cmbVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFort_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowApply = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;
            if (fd.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(txtDescription.Text))
            {

                txtDescription.SelectionFont = fd.Font;
                txtDescription.SelectionColor = fd.Color;

            }
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            var getid = txtPatientID.Text;
            var patientRegistrationForm  = new PatientRegistrationForm();
            patientRegistrationForm.Show();
            patientRegistrationForm.SearchButtonEnable = false;
            patientRegistrationForm.TextId = getid;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _medicalHistory.Insert(txtMedicalId.Text, txtPatientID.Text, txtDescription.Text);
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _medicalHistory.Update(txtMedicalId.Text, txtDescription.Text);
            Refresh();
        }

       
    }
}
