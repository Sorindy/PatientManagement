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

        private Management _management=new Management();
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            cboControl.DataSource = _management.Show_Control();
          //  cboControl.Text = "";
            dgvShow.DataSource = _management.Show_WorkerHasAccount();
        //    groupBox1.Controls.Add(management.Show_ControlForm());            
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
        groupBox1.Controls.Clear();
          groupBox1.Controls.Add(_management.ShowControlForm(cboControl.Text));  
        }

    }
}
