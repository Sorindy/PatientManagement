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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSearchWorker.DataSource = _management.Search_WorkerHasAccount(txtSearch.Text);
            dgvSearchWorker.Columns[0].Visible = false;
            DtgHeaderText();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DtgHeaderText()
        {
            dgvSearchWorker.Columns[1].HeaderText = @"ត្រកូល";
            dgvSearchWorker.Columns[2].HeaderText = @"ឈ្មោះ";
            dgvSearchWorker.Columns[3].HeaderText = @"ភេទ";
            dgvSearchWorker.Columns[4].HeaderText = @"តួនាទី";
        }
    }
}
