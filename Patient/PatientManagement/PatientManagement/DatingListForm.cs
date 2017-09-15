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
    public partial class DatingListForm : Form
    {
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
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        private void DatingListForm_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnNew.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnNew.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Visible = false;
            btnAdd.Visible = true;
        }
    }
}
