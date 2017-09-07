using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public Patient Pt = new Patient();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgInformation.DataSource = Pt.Search_Patient(txtSearch.Text);
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            var getid = dtgInformation.CurrentRow.Cells[0].Value.ToString();
            Hide();
            var ptrf = new PatientRegistrationForm();
            ptrf.Show();
            ptrf.TextId = getid;

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

    }
}
