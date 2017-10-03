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
    public partial class MedicalHistoryForm : Form
    {
        public MedicalHistoryForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Hide();
            var mediccalform = new MedicalForm();
            mediccalform.Show();
            Refresh();
            
        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {
            tmTime.Start();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = Convert.ToString(DateTime.Now);
        }
    }
}
