using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Login
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private Hospital_Entity_Framework.Account _account;

        public Hospital_Entity_Framework.Account LoginAccount(string username, string password)
        {
            var check = _db.Accounts.SingleOrDefault(v => v.UserName == username && v.Password == password && v.Worker.Hire);
            return check;
        }

        public FlowLayoutPanel ButtonToForm(Hospital_Entity_Framework.Account account)
        {
            var flpn=new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Name = @"flpnButtonForm",
                AutoScroll = true,
                WrapContents = false
            };
            _account = account;
            var firstOrDefault = _db.Managements.FirstOrDefault(v => v.AccountId == account.Id);
            if (firstOrDefault != null)
            {
                var checkForm = firstOrDefault.Forms;

                foreach (var form in checkForm)
                {
                    var color = ColorTranslator.FromHtml("#3399FF");
                    var btn=new Button
                    {
                        Font=new Font("Nova Cut",12),
                        Text = form.Name.Remove(form.Name.Length-7),
                        Height = 50,
                        Width = flpn.Width,
                        BackColor = Color.FromArgb(128,color)
                    };

                    btn.MouseHover += MouseHover;
                    btn.MouseLeave += MouseLeave;
                    btn.Click += OpenForm;

                    flpn.Controls.Add(btn);
                }
            }
            return flpn;
        }

        private void MouseHover(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            btn.BackColor=Color.Green;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var color = ColorTranslator.FromHtml("#3399FF");
            btn.BackColor = Color.FromArgb(128,color);
        }

        private void OpenForm(object sender,EventArgs e)
        {
            var btn = (Button) sender;
            var text = btn.Text;

            var form = (CatelogForm)Application.OpenForms["CatelogForm"];
            if (form != null)
            {
                var gbo = form.pnlFill;
                gbo.Controls.Clear();

                if (text == "Worker")
                {
                    if (Application.OpenForms.OfType<WorkerListForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<WorkerListForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                            firstOrDefault.Close();
                    }
                    var selectionForm = new WorkerListForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
                if (text == "Category")
                {
                    if (Application.OpenForms.OfType<Category>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<Category>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                        var selectionForm = new Category()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
                if (text == "Patient")
                {
                    if (Application.OpenForms.OfType<PatientListForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<PatientListForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                        var selectionForm = new PatientListForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            Account = _account
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
                if (text == "CheckIn")
                {
                    if(Application.OpenForms.OfType<CheckInsForm>().Count()==1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<CheckInsForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                    var selectionForm = new CheckInsForm
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
                if (text == "Sample")
                {
                    if (Application.OpenForms.OfType<SamplesForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<SamplesForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                        var selectionForm = new SamplesForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
                if (text == "Management")
                {
                    if (Application.OpenForms.OfType<Managements>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<Managements>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                    var selectionForm = new Managements()
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        AutoScroll = true
                    };
                    gbo.Controls.Add(selectionForm);
                    selectionForm.Show();
                }
                if (text == "Medical")
                {
                    if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Show();
                        }                           
                    }
                        var selectionForm = new MedicalsForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            Account = _account
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                }
            }
        }
    }
}
