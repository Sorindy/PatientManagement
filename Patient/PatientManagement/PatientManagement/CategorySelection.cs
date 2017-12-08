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
            Close();
        }

        private void CategorySelection_Shown(object sender, EventArgs e)
        {
            tabCategory.Controls.Add(_fullManagement.TabConsultation(Account,this));
        }

    }
}
