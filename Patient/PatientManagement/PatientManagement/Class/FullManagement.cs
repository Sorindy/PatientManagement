using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class FullManagement
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private Hospital_Entity_Framework.Account _account;

        public FlowLayoutPanel ButtonSelectForm(Hospital_Entity_Framework.Account acc)
        {
            ClearTemp();

            var flpn=new FlowLayoutPanel();
            flpn.Controls.Clear();
            flpn.Dock=DockStyle.Fill;
            flpn.AutoScroll = true;

            _account = acc;
            var getFormlist = _db.Forms;
            foreach (var item in getFormlist)
            {
                var chkAcc = _db.Managements.First(v=>v.AccountId==acc.Id).Forms.Any(v=>v.Id==item.Id);

                if (chkAcc)
                {
                    var btn = new Button
                    {
                        Size = new Size(180, 90),
                        Text = item.Name,
                        Name = item.Id.ToString(),
                        BackColor = Color.LimeGreen,
                        Font = new Font("November", 12)
                    };

                    var insertTemp=new TempManagement{Categorys = item.Id.ToString(),Forms = item.Name,WorkerId = acc.WorkerId,Services = item.Name};
                    _db.TempManagements.Add(insertTemp);
                    flpn.Controls.Add(btn);
                    btn.Click += RemoveService_Click;
                }
                else
                {
                    var btn = new Button
                    {
                        Location = new Point(3, 3),
                        Size = new Size(160, 81),
                        Text = item.Name,
                        Name = item.Id.ToString(),
                        BackColor = Color.Khaki,
                        Font = new Font("November", 12)
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += TakeService_Click;
                }
            }
            _db.SaveChanges();
            return flpn;
        }

        private void TakeService_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            var getName = check.Name;
            var getText = check.Text;

            var insert = new TempManagement() {WorkerId = _account.WorkerId,Categorys = getName,Forms = getText,Services = getText};
            _db.TempManagements.Add(insert);
            _db.SaveChanges();

            var form = (Managements)Application.OpenForms["Managements"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ButtonSelectForm(_account));
            }
        }

        private void RemoveService_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            var getName = check.Name;

            var delete = _db.TempManagements.Single(v => v.Categorys == getName);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            var form = (CheckInsForm)Application.OpenForms["CheckInsForm"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ButtonSelectForm(_account));
            }
        }

        private void ClearTemp()
        {
            var clear = _db.TempManagements;
            _db.TempManagements.RemoveRange(clear);
            _db.SaveChanges();
        }

        public object Search_WorkerHasAccount(string search)
        {
           var bs2 = new BindingSource();

            var searchs = _db.Accounts.Where(v => v.Worker.Name.Contains(search) ||
                                                  v.Worker.Position.Contains(search));

            bs2.DataSource = searchs
                .Select(s => new {s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName }).ToList();

            return bs2;
        }

        public Hospital_Entity_Framework.Account Account(int workerId)
        {
            var getAcc = _db.Accounts.First(v => v.WorkerId == workerId);

            return getAcc;
        }
    }
}
