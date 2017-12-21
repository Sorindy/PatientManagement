﻿using System;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class MedicalsForm : Form
    {
        public MedicalsForm()
        {
            InitializeComponent();
        }

        private string _path;
        internal Account Account;
        internal Patient Patient;

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MedicalsForm_Shown(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
        }

        private void picHideTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picHideTop")
            {
                picHideTop.Name = "picShowTop";
                picHideTop.ImageLocation = _path + @"Hide-down-icon.png";
                pnlTitle.Visible = false;
                picHideTop.Click += picShowTop_Click;
            }
        }

        private void picShowTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picShowTop")
            {
                picHideTop.Name = "picHideTop";
                picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
                pnlTitle.Visible = true;
                picHideTop.Click -= picShowTop_Click;
            }
        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
                pnlButton.Visible = true;
                picHideRight.Click -=picShowRight_Click;
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            var form=new SearchPatient(){MedicalsForm = this};
            form.ShowDialog();
            if (Patient != null)
            {
                txtNamePatient.Text = Patient.Name;
                txtGenderPatient.Text = Patient.Gender;
                if (btnPatient.Name == "btnPatient")
                {
                    btnPatient.Name = "btnInfoPatient";
                    btnPatient.Text = @"ពត៍មាន​ បន្ថែម";
                    btnPatient.Click += btnInfoPatient_Click;
                    btnPatient.Click -= btnPatient_Click;
                }
            }
        }

        private void btnInfoPatient_Click(object sender, EventArgs e)
        {
            if (btnPatient.Name == "btnInfoPatient")
            {
                var form=new PatientForm(){Patient = Patient,Account = Account};
                form.ShowDialog();
            }
        }
    }
}