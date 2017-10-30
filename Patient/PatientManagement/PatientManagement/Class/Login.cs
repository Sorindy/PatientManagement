using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Login
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();

        public Hospital_Entity_Framework.Account LoginAccount(string username, string password)
        {
            var check = _db.Accounts.SingleOrDefault(v => v.UserName == username && v.Password == password);
            return check;
        }

        public TableLayoutPanel ButtonToForm(Hospital_Entity_Framework.Account account)
        {
            var flpn=new TableLayoutPanel()
            {
                ColumnCount = 2,
                ColumnStyles = { new ColumnStyle(SizeType.Percent,30F),new ColumnStyle(SizeType.Percent, 70F)},
                RowCount = 1,
                RowStyles = { new RowStyle(SizeType.Absolute,50F)},
                Dock = DockStyle.Fill
            };
            var firstOrDefault = _db.Managements.FirstOrDefault(v => v.AccountId == account.Id);
            if (firstOrDefault != null)
            {
                var checkForm = firstOrDefault.Forms;
                int i = -1;

                foreach (var form in checkForm)
                {
                    i += 1;
                    var btn=new Label
                    {
                        Font = new Font("Nova Cut",16),
                        Text = form.Name
                    };
                    var pic = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        ImageLocation = "E:\\Work\\PatientManagement\\Patient\\119040-medical-elements\\119040-medical-elements\\png\\apple.png"
                    };
                    flpn.Controls.Add(pic,1,i);
                    flpn.Controls.Add(btn,2,i);
                }
            }
            return flpn;
        }
    }
}
