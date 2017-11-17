﻿using System;
using System.Drawing;
using System.Linq;
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
                    var selectedForm = new WorkerListForm
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        AutoScroll = true
                    };
                    gbo.Controls.Add(selectedForm);
                    selectedForm.Show();
                }
                if (text == "Category")
                {
                    var selectionForm=new Category
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        AutoScroll =true
                    };
                    gbo.Controls.Add(selectionForm);
                    selectionForm.Show();
                }
                if (text == "Patient")
                {
                    var selectionForm=new PatientListForm()
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        AutoScroll = true
                    };
                    gbo.Controls.Add(selectionForm);
                    selectionForm.Show();
                }
                if (text == "CheckIn")
                {
                    var selectionForm=new CheckInsForm
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        AutoScroll = true
                    };
                    gbo.Controls.Add(selectionForm);
                    selectionForm.Show();
                }
            }
        }
    }
}
