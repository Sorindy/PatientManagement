using System;
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
    public partial class DatingListForm : Form
    {

        private Dating _dating = new Dating();
        private Worker _worker = new Worker();
        private Patient _patient = new Patient();

        public DatingListForm()
        {
            InitializeComponent();
        }

        public string StaffId
        {
            get { return txtStaffID.Text; }
            set { txtStaffID.Text = value; }
        }

        public string PatientId 
        {
            get { return txtPatientId.Text; }
            set { txtPatientId.Text = value; }
        }

        private void DatingListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           _dating.Insert(_dating.AutoId(),txtPatientId.Text,txtStaffID.Text,dtpDating.Value);
            btnShow.PerformClick();
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm();
            Hide();
            search.Show();
            search.Staffid = txtStaffID.Text;
            Refresh();
            search.SubmitButton = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _dating.Update(txtDatingId.Text, dtpDating.Value);
            btnShow.PerformClick();
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _dating.Delete(txtDatingId.Text);
            btnShow.PerformClick();
            Clear();
            Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Refresh();
        }

        public void Clear()
        {
            txtDatingId.Text = "";
            dtpDating.Text = Convert.ToString(DateTime.Now);
            Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           dtgInformation.DataSource= _dating.Show(txtStaffID.Text);
            Refresh();
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            var select = _worker.SelectedChange(txtStaffID.Text);
            txtStaffName.Text = select.Name;
            Refresh();
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDatingId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
            dtpDating.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
            txtPatientId.Text = dtgInformation.CurrentRow.Cells[2].Value.ToString();
            Refresh();
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {
            var select = _patient.Select(txtPatientId.Text);
            txtPatientName.Text = select.Name;
            Refresh();
        }
    }
}
