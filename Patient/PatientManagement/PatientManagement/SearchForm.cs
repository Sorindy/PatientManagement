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

        private Patient _patient;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _patient = new Patient();
            dtgInformation.DataSource = _patient.Search(txtSearch.Text);
            Refresh();    
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
            var patientRegistrationForm = new PatientRegistrationForm();
            patientRegistrationForm.Show();
            patientRegistrationForm.TextId = getid;

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

    }
}
