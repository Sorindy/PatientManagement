﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        internal PatientListForm PatientListForm;
        internal Patient Patient;
        internal HistorysForm HistorysForm;
        private readonly Class.Patient _patient=new Class.Patient();
        private bool _mouseDown;
        private Point _lastLocation;

        private void PatientForm_Shown(object sender, EventArgs e)
        {
            Clear();
            Patient = _patient.Select(Patient.Id);
            txtId.Text = Patient.PatientIdentify.ToString();
            txtfName.Text = Patient.FirstName;
            txtlName.Text = Patient.LastName;
            txtkhName.Text = Patient.KhmerName;
            cboGender.Text = Patient.Gender;
            dtpDOB.Value = Patient.DOB;
            txtAge.Text = Patient.Age.ToString();
            txtPhone1.Text = Patient.Phone1;
            txtPhone2.Text = Patient.Phone2;
            txtEmail.Text = Patient.Email;
            txtAddress.Text = Patient.Address;
            txtWeight.Text = Patient.Weight.ToString();
            txtHeight.Text = Patient.Height.ToString();

            btnEdit.Focus();

            txtId.Enabled = false;
            txtfName.Enabled = false;
            txtlName.Enabled = false;
            txtkhName.Enabled = false;
            cboGender.Enabled = false;
            dtpDOB.Enabled = false;
            txtAge.Enabled = false;
            txtPhone1.Enabled = false;
            txtPhone2.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
            txtWeight.Enabled = false;
            txtHeight.Enabled = false;

            btnClear.Enabled = false;
            btnUpdate.Enabled = false;

            dtpDOB.CustomFormat = @"dd/MM/yyyy";
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

            if (PatientListForm != null)
            {
                PatientListForm.dgvListPatient.Columns.Clear();
                PatientListForm.PatientListForm_Shown(PatientListForm, new EventArgs());
            }
            if (HistorysForm == null) return;
            //HistorysForm.CatelogForm.pnlFill.Controls.Clear();
            //HistorysForm.CatelogForm.pnlFill.Controls.Add(HistorysForm);
            //HistorysForm.dgvConsultation.Columns.Clear();
            //HistorysForm.dgvLaboratory.Columns.Clear();
            //HistorysForm.dgvMedicalImaging.Columns.Clear();
            //HistorysForm.dgvPrescription.Columns.Clear();
            //HistorysForm.dgvVariousDocument.Columns.Clear();
            HistorysForm.Show();
        }

        private void Clear()
        {
            txtfName.Text = "";
            txtlName.Text = "";
            txtkhName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
            dtpDOB.Value = DateTime.Today;
            cboGender.Text = @"Female";
            txtfName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnEdit")
            {
                btnEdit.Text = @"Cancel";
                btnEdit.BackColor = Color.LightSkyBlue;
                btnEdit.Image = Properties.Resources._46795___clear_delete_remove;
                btnEdit.Name = @"btnCancel";
                btnEdit.Click += btnCancel_Click;
            }

            txtfName.Enabled = true;
            txtlName.Enabled = true;
            txtkhName.Enabled = true;
            cboGender.Enabled = true;
            dtpDOB.Enabled = true;
            txtAge.Enabled = true;
            txtPhone1.Enabled = true;
            txtPhone2.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
            txtWeight.Enabled = true;
            txtHeight.Enabled = true;

            txtfName.Focus();
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnCancel")
            {
                btnEdit.Name = @"btnEdit";
                btnEdit.BackColor = Color.LightSkyBlue;
                btnEdit.Image = Properties.Resources._46798___control_edit;
                btnEdit.Text = @"Edit";
                btnEdit.Click -= btnCancel_Click;
            }

            PatientForm_Shown(this,new EventArgs());
        }

        private void CheckData()
        {
            if (txtfName.Text.Trim() == "" || txtfName.Text == null)
            {
                MessageBox.Show(@"Please fill First Name.");
                txtfName.Focus();
            }
            if (txtlName.Text.Trim() == "" || txtlName.Text == null)
            {
                MessageBox.Show(@"Please fill Last Name.");
                txtlName.Focus();
            }
            if (txtkhName.Text.Trim() == "" || txtkhName.Text == null)
            {
                txtkhName.Text = @"None";
                txtfName.Focus();
            }
            if (txtAddress.Text.Trim() == "" || txtAddress.Text == null)
            {
                MessageBox.Show(@"Please fill Address.");
                txtAddress.Focus();
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                MessageBox.Show(@"Please fill Phone1.");
                txtPhone1.Focus();
            }
            if (txtPhone2.Text.Trim() == "" || txtPhone2.Text == null)
            {
                txtPhone2.Text = @"None";
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text == null)
            {
                txtEmail.Text = @"None";
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtlName.Text + @" date of birth correct.");
                dtpDOB.Focus();
            }
            if (txtWeight.Text.Trim() == "" || txtWeight.Text == null)
            {
                MessageBox.Show(@"Please input weight .");
                txtWeight.Focus();
            }
            if (txtHeight.Text.Trim() == "" || txtHeight.Text == null)
            {
                MessageBox.Show(@"Please input height .");
                txtHeight.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _patient.Update(Patient.Id,txtfName.Text,txtlName.Text,txtkhName.Text,cboGender.Text,dtpDOB.Value,Convert.ToByte(txtAge.Text),txtAddress.Text,txtPhone1.Text,
                    txtPhone2.Text,txtEmail.Text,Convert.ToInt16(txtWeight.Text),Convert.ToInt16(txtHeight.Text));
                PatientForm_Shown(this,new EventArgs());
                btnEdit.Name = @"btnEdit";
                btnEdit.BackColor = Color.LightSkyBlue;
                btnEdit.Image = Properties.Resources._46798___control_edit;
                btnEdit.Text = @"Edit";
                btnEdit.Click -= btnCancel_Click;
            }
            catch
            {
                CheckData();
                MessageBox.Show(@"Please checking again .", @"Error");
            }
        }

        //private void btnHistory_Click(object sender, EventArgs e)
        //{
        //    if (Account != null && Patient !=null)
        //    {
        //        var form = new HistorysForm() { Patient = Patient, Account = Account };
        //        form.ShowDialog();
        //        Close();
        //    }
        //}

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
