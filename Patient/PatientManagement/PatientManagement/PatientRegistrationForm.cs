using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class PatientRegistrationForm : Form
    {

        public Patient Pt = new Patient();

        public PatientRegistrationForm()
        {
            InitializeComponent();
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
            try
            {

                Pt.Cheack_Control(txtName.Text, cmbGender.Text, txtAddress.Text, txtPhone1.Text, txtWeight.Text, txtHeight.Text);
                Pt.Insert_Patient(txtID.Text, txtName.Text, cmbGender.Text, dtpDOB.Value.Date, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Convert.ToInt16(txtHeight.Text), Convert.ToInt16(txtHeight.Text));
                Clear_Control();
                btnNew.Visible = true;
                btnInsert.Visible = false;
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

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
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Pt.Update_Patient(txtID.Text, txtName.Text, cmbGender.Text, dtpDOB.Value.Date, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, Convert.ToInt16(txtHeight.Text), Convert.ToInt16(txtHeight.Text));
                Clear_Control();
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            txtID.Text = Pt.AutoId_Patient();
            btnInsert.Visible = true;
            btnNew.Visible = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Pt.Select_Patient(txtID.Text);
            txtName.Text = Pt.Name;
            txtAge.Text = Pt.Age.ToString();
            txtAddress.Text = Pt.Address;
            txtEmail.Text = Pt.Email;
            txtPhone1.Text = Pt.Phone1;
            txtPhone2.Text = Pt.Phone2;
            txtHeight.Text = Pt.Height.ToString();
            txtWeight.Text = Pt.Weight.ToString();
            cmbGender.Text = Pt.Gender;
            dtpDOB.Text = Convert.ToString(Pt.DOB);
        }

       

    }
}
