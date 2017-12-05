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
            pnlSelection.Controls.Clear();
            pnlSelection.Controls.Add(_management.ButtonSelectForm(Account));
            txtName.Text = Account.Worker.Name;
            txtPosition.Text = Account.Worker.Position;
        }

        private void picboxSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchWorker() { Managements = this };
            form.ShowDialog();
            pnlSelection.Controls.Clear();
            pnlSelection.Controls.Add(_management.ButtonSelectForm(Account));
            txtName.Text = Account.Worker.Name;
            txtPosition.Text = Account.Worker.Position;
        }

        private void tblSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchWorker() { Managements = this };
            form.ShowDialog();
            pnlSelection.Controls.Clear();
            pnlSelection.Controls.Add(_management.ButtonSelectForm(Account));
            txtName.Text = Account.Worker.Name;
            txtPosition.Text = Account.Worker.Position;
        }

    }
}
