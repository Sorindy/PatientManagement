using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private readonly Management _management = new Management();

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            dgvShow.DataSource = _management.Show_WorkerHasAccount();
            _management.ClearTemp();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvShow.DataSource = _management.Search_WorkerHasAccount(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            gboControlName.Controls.Clear();
            if (dgvShow.CurrentRow != null)
                gboControlName.Controls.Add(_management.ChoosenFormPanel((cboControl.Text),
                    Convert.ToInt32(dgvShow.CurrentRow.Cells[0].Value)));
        }

        
        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null)
                gboControlName.Text = dgvShow.CurrentRow.Cells[4].Value + @"'s Control";
            cboControl.DataSource = _management.Show_Control();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null) _management.SubmitManagement(Convert.ToInt32(dgvShow.CurrentRow.Cells[0].Value));
        }

    }
}
