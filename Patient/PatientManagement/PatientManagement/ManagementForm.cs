using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        protected Management management=new Management();

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            cboControl.DataSource = management.Show_Control();
          //  cboControl.Text = "";
            dgvShow.DataSource = management.Show_WorkerHasAccount();
        //    groupBox1.Controls.Add(management.Show_ControlForm());            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvShow.DataSource = management.Search_WorkerHasAccount(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        groupBox1.Controls.Clear();
          groupBox1.Controls.Add(management.Show_ControlForm(cboControl.Text));  
        }

    }
}
