using System;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class Managements : Form
    {
        public Managements()
        {
            InitializeComponent();
        }

        internal Account Account;
        private readonly FullManagement _management=new FullManagement();

        private void lblSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchWorker() { Managements = this};
            form.ShowDialog();
            _management.ClearTemp();
            pnlSelection.Controls.Clear();
            if (Account != null)
            {
                pnlSelection.Controls.Add(_management.ButtonSelectionForm(this));
                txtName.Text = Account.Worker.FirstName + @"  " + Account.Worker.LastName;
                txtPosition.Text = Account.Worker.Position;
            }
        }

        private void picboxSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchWorker() { Managements = this };
            form.ShowDialog();
            _management.ClearTemp();
            pnlSelection.Controls.Clear();
            if (Account != null)
            {
                pnlSelection.Controls.Add(_management.ButtonSelectionForm(this));
                txtName.Text = Account.Worker.FirstName + @"  " + Account.Worker.LastName;
                txtPosition.Text = Account.Worker.Position;
            }
        }

        private void tblSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchWorker() { Managements = this };
            form.ShowDialog();
            _management.ClearTemp();
            pnlSelection.Controls.Clear();
            if (Account != null)
            {
                pnlSelection.Controls.Add(_management.ButtonSelectionForm(this));
                txtName.Text = Account.Worker.FirstName + @"  " + Account.Worker.LastName;
                txtPosition.Text = Account.Worker.Position;
            }
        }

        private void Managements_Shown(object sender, EventArgs e)
        {
            _management.ClearTemp();
            txtName.Text = "";
            txtPosition.Text = "";
            pnlSelection.Controls.Clear();
            txtName.Enabled = false;
            txtPosition.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Account != null)
            {
                _management.SubmitManagement(Account);
                Managements_Shown(this, new EventArgs());
            }
            else
            {
                MessageBox.Show(@"Please input any data",@"Save");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msg= MessageBox.Show(@"  Are you sure want to delete this management? This deletion is going to delete both of your management and account.",@"Delete",MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                if (Account != null)
                {
                    _management.DeleteManagementAndAccount(Account);
                    Managements_Shown(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(@"Please input any data",@"Delete");
                }
            }
        }
    }
}
