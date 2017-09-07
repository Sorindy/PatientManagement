using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;


namespace PatientManagement
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }
        

        private void SampleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFort_Click(object sender, EventArgs e)
        {


            _fd = new FontDialog();
            _fd.ShowColor = true;
            _fd.ShowApply = true;
            _fd.ShowEffects = true;
            _fd.ShowHelp = true;
            if (_fd.ShowDialog() == DialogResult.OK)
            {
                txtDescription.Font = _fd.Font;
                txtDescription.ForeColor = _fd.Color;
            }

        }

        private void _fd_Apply(object sender, EventArgs e)
        {
            txtDescription.Font = _fd.Font;
            txtDescription.ForeColor  = _fd.Color;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Visible = false;
            btnInsert.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnInsert.Visible = false;
            btnNew.Visible = true;
        }


    }
}
    
