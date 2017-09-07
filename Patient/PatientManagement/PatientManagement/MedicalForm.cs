using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class MedicalForm : Form
    {
        public MedicalForm()
        {
            InitializeComponent();
        }

        public MedicalHistory Mh = new MedicalHistory();
        public Consultation_sCategory Cc = new Consultation_sCategory();
        public Prescription_sCategory Pc = new Prescription_sCategory();
        public VariousDocument_sCategory Vc = new VariousDocument_sCategory();
        public MedicalImaging_sCategory Mc = new MedicalImaging_sCategory();
        public Laboratory_sCategory Lc = new Laboratory_sCategory();


        private void MedicalForm_Load(object sender, EventArgs e)
        {

            lbTodaydate.Text = DateTime.Today.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            var getid = txtPatientID.Text;
            var ptrf = new PatientRegistrationForm();
            ptrf.Show();
            ptrf.TextId = getid;
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            btnSubmit.Visible = false;
            btnNew.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
            btnNew.Visible = false;
            btnSubmit.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}


