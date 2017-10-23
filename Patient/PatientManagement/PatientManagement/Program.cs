using System;
using System.Windows.Forms;

namespace PatientManagement
{
   internal static class Program
    {
        [STAThread]
      private  static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new ManagementForm());
=======
            Application.Run(new CategoryForm());
>>>>>>> e22f8da121bdd77b5c2db0d3f4d3806289d85e07
        }
    }
}