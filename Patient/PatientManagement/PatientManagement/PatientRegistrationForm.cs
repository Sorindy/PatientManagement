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
    public partial class PatientRegistrationForm : Form
    {

        private Patient _patient = new Patient();
        public CheckInForm Checkinkform;
        private MedicalRecord _medicalRecord = new MedicalRecord();

        public PatientRegistrationForm()
        {
            InitializeComponent();
        }

        public bool SearchButtonEnable
        {
            get { return btnSearch.Enabled ; }
            set { btnSearch.Enabled = value; }
        }

        public string TextId
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }

        private void PatientRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
                _patient.Cheack_Control(txtName.Text, cmbGender.Text, txtAddress.Text, txtPhone1.Text, txtWeight.Text, txtHeight.Text);
                _patient.Insert(txtID.Text, txtName.Text, cmbGender.Text, dtpDOB.Value.Date, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Convert.ToInt16(txtWeight.Text), Convert.ToInt16(txtHeight.Text));
                _medicalRecord.Insert(_medicalRecord.AutoId(), txtID.Text);
                Clear_Control();
                btnNew.Visible = true;
                btnInsert.Visible = false;
                Refresh();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Convert.ToString(DateTime.Today.Year - dtpDOB.Value.Year);
            Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm();
            search.Show();
            Refresh();
            search.AddDatingButton = false;
            search.PatientRegistrationForm = this;
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
            try
            {
                Checkinkform.Show();

            }
            catch
            {
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                _patient.Update(txtID.Text, txtName.Text, cmbGender.Text, dtpDOB.Value.Date, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Convert.ToInt16(txtWeight.Text), Convert.ToInt16(txtHeight.Text));
                Clear_Control();
                Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void Clear_Control()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            cmbGender.Text = "";
            dtpDOB.Value = DateTime.Today;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_Control();
            txtID.Text =_patient.AutoId();
            btnInsert.Visible = true;
            btnNew.Visible = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
