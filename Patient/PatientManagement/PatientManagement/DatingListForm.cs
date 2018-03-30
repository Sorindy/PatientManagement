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
            CheckPatientAndWorker();
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
            if (lbPatientName.Text != null)
            {
                _dating.Update(Convert.ToInt32(lbDatingId.Text), dtpDating.Value);
                btnShow.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPatientName.Text != null)
            {
                _dating.Delete(Convert.ToInt32(lbDatingId.Text));
                btnShow.PerformClick();
                Clear();
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CheckPatientAndWorker()
        {
            if (Patient != null)
            {
               lbPatientName.Text = Patient.FirstName + @"  " + Patient.LastName;
            }
            if (Worker != null)
            {
                lbStaffName.Text = Worker.FirstName + @"  " + Worker.LastName;
            }
        }

        public void Clear()
        {
            lbDatingId.Text = "";
            dtpDating.Text = Convert.ToString(DateTime.Now, CultureInfo.InvariantCulture);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtgInformation.DataSource = _dating.Show(Worker.Id);
            DtgInformationHeaderText();
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                lbDatingId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                dtpDating.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
                lbPatientName.Text = dtgInformation.CurrentRow.Cells[3].Value.ToString();
            }
        }

        public void DtgInformationHeaderText()
        {
            try
            {
                dtgInformation.Columns[0].Visible = false;
                dtgInformation.Columns[2].Visible = false;
                dtgInformation.Columns[6].Visible = false;
                dtgInformation.Columns[1].HeaderText = @"កាលបរិច្ឆេទ";
                dtgInformation.Columns[3].HeaderText = @"ត្រកូល";
                dtgInformation.Columns[4].HeaderText = @"ឈ្មោះ";
                dtgInformation.Columns[5].HeaderText = @"ឈ្មោះខ្មែរ";
                
            }
            catch
            {
            }
        }

    }
}
