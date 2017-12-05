using System;
using PatientManagement.Class;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class SearchWorker : Form
    {
        public SearchWorker()
        {
            InitializeComponent();
        }

        private readonly FullManagement _management=new FullManagement();
        internal Managements Managements;

        private void SearchWorker_Shown(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
            btnAdd.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSearchWorker.DataSource = _management.Search_WorkerHasAccount(txtSearch.Text);
            dgvSearchWorker.Columns[0].Visible = false;
        }

        private void dgvSearchWorker_SelectionChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvSearchWorker.DataSource != null)
            {
                if (dgvSearchWorker.CurrentRow != null)
                {
                    var getId = Convert.ToInt32(dgvSearchWorker.CurrentRow.Cells[0].Value);

                    Managements.Account = _management.Account(getId);
                    Close();
                }
            }
        }
    }
}
