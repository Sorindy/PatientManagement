using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using PatientManagement;
using PatientManagement;

namespace PatientManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SampleForm());
        }
    }
}