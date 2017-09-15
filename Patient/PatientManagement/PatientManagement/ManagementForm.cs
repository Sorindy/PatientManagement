using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Management _management = new Management();

        private void ManagementForm_Load(object sender, EventArgs e)
        {
           // cboControl.DataSource = _management.Show_Control();
            dgvShow.DataSource = _management.Show_WorkerHasAccount();
            cboPreview.DataSource = _management.Show_Control();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvShow.DataSource = _management.Search_WorkerHasAccount(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtControl.Text = cboControl.Text;
            tviewControl.CheckBoxes = true;
            tviewControl.Nodes.Clear();
            tviewControl.Nodes.Add(_management.ChoosenForm(cboControl.Text));
        }

        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null)
                gboControlName.Text = dgvShow.CurrentRow.Cells[4].Value.ToString() + @"'s Control";
            cboControl.DataSource = _management.Show_Control();
        }

        private void cboPreview_TextChanged(object sender, EventArgs e)
        {
           // flpnPreview tviewControl.SelectedNode;
        }
    }
}
