using System;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        internal PatientListForm PatientListForm;
        internal Patient Patient;

        private void PatientForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
