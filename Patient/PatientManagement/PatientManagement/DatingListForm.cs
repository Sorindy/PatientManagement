using System;
using System.Globalization;
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
            _dating.Insert(Convert.ToInt32(txtPatientId.Text), Convert.ToInt32(txtStaffID.Text), dtpDating.Value);
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
            _dating.Update(Convert.ToInt32(txtDatingId.Text), dtpDating.Value);
            btnShow.PerformClick();
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            _dating.Delete(Convert.ToInt32(txtDatingId.Text));
=======
            _dating.Delete(Convert.ToInt32( txtDatingId.Text));
>>>>>>> e22f8da121bdd77b5c2db0d3f4d3806289d85e07
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
            dtpDating.Text = Convert.ToString(DateTime.Now, CultureInfo.InvariantCulture);
            Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            dtgInformation.DataSource = _dating.Show(Convert.ToInt32(txtStaffID.Text));
=======
           dtgInformation.DataSource= _dating.Show(Convert.ToInt32( txtStaffID.Text));
>>>>>>> e22f8da121bdd77b5c2db0d3f4d3806289d85e07
            Refresh();
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var select = _worker.SelectedChange(Convert.ToInt32(txtStaffID.Text));
=======
            var select = _worker.SelectedChange(Convert.ToInt32( txtStaffID.Text));
>>>>>>> e22f8da121bdd77b5c2db0d3f4d3806289d85e07
            txtStaffName.Text = select.Name;
            Refresh();
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                txtDatingId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                dtpDating.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
                txtPatientId.Text = dtgInformation.CurrentRow.Cells[2].Value.ToString();
            }
            Refresh();
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var select = _patient.Select(Convert.ToInt32(txtPatientId.Text));
=======
            var select = _patient.Select(Convert.ToInt32( txtPatientId.Text));
>>>>>>> e22f8da121bdd77b5c2db0d3f4d3806289d85e07
            txtPatientName.Text = select.Name;
            Refresh();
        }
    }
}
