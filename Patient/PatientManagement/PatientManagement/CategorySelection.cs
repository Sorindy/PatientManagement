using System;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;

namespace PatientManagement
{
    public partial class CategorySelection : Form
    {
        public CategorySelection()
        {
            InitializeComponent();
        }

        private readonly FullManagement _fullManagement=new FullManagement();
        internal Account Account;

        private void button3_Click(object sender, EventArgs e)
        {
            _fullManagement.ClearCatergory(Account,this);
            Close();
        }

        private void CategorySelection_Shown(object sender, EventArgs e)
        {
            tabCategory.Controls.AddRange(new Control[] { _fullManagement.TabConsultation(Account, this),
                _fullManagement.TabLaboratory(Account, this),
                _fullManagement.TabMedicalImaging(Account,this),
                _fullManagement.TabPrescription(Account,this),
                _fullManagement.TabVariousDocument(Account,this)
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _fullManagement.ClearCatergory(Account,this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _fullManagement.SubmitCategory(Account,this);
        }

    }
}
