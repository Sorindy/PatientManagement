using System;
using System.Globalization;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Dating = PatientManagement.Class.Dating;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class DatingListForm : Form
    {

        private readonly Dating _dating = new Dating();
        internal Patient Patient ;
        internal Worker Worker ;

        public DatingListForm()
        {
            InitializeComponent();
        }

        private void DatingListForm_Load(object sender, EventArgs e)
        {
            if (Patient != null && Worker!= null )
            {
                txtPatientName.Text = Patient.Name;
                txtStaffName.Text = Worker.Name;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Patient != null && Worker != null)
            {
                _dating.Insert(Patient.Id, Worker.Id, dtpDating.Value);
                btnShow.PerformClick();
            }   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchpatient = new SearchPatient
            {
                Datinglistform=this
            };
            searchpatient.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text != null)
            {
                _dating.Update(Convert.ToInt32(txtDatingId.Text), dtpDating.Value);
                btnShow.PerformClick();
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text != null)
            {
                _dating.Delete(Convert.ToInt32(txtDatingId.Text));
                btnShow.PerformClick();
                Clear();
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtDatingId.Text = "";
            dtpDating.Text = Convert.ToString(DateTime.Now, CultureInfo.InvariantCulture);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtgInformation.DataSource = _dating.Show(Worker.Id);
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                txtDatingId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                dtpDating.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
                txtPatientName.Text = dtgInformation.CurrentRow.Cells[3].Value.ToString();
            }
        }

    }
}
