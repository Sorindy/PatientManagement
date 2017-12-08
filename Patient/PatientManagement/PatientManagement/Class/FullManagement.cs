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
        private CategorySelection _categorySelection;

        public FlowLayoutPanel ButtonSelectForm(Hospital_Entity_Framework.Account acc)
        {
            var flpn=new FlowLayoutPanel();
            flpn.Controls.Clear();
            flpn.Dock=DockStyle.Fill;
            flpn.AutoScroll = true;

            _account = acc;
            var getFormlist = _db.Forms;
            var getOldManagement = _db.Managements.FirstOrDefault(v => v.AccountId == acc.Id);
            foreach (var item in getFormlist)
            {
                if (getOldManagement != null)
                {
                    var chkAcc = getOldManagement.Forms.Any(v => v.Id == item.Id);

                    if (chkAcc)
                    {
                        if (item.Name == "Medical's Form")
                        {
                            var btn = new Button
                            {
                                Size = new Size(180, 90),
                                Text = item.Name,
                                Name = item.Id.ToString(),
                                BackColor = Color.LimeGreen,
                                Font = new Font("November", 12)
                            };

                            var input = new TempManagement() { Categorys = item.Id.ToString(), Forms = item.Name, Services = item.Name, WorkerId = acc.WorkerId };
                            _db.TempManagements.Add(input);
                            flpn.Controls.Add(btn);
                            btn.Click += RemoveService_Click;

                            if (_db.TempManagements.Any(v => v.Forms == "Consultation")==false)
                            {
                                foreach (var itemConsultationCategory in getOldManagement.ConsultationCategories)
                                {
                                    var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = item.Name, Forms = "Consultation", Categorys = itemConsultationCategory.Id.ToString() };
                                    _db.TempManagements.Add(inputCategory);
                                }
                            }

                            if (_db.TempManagements.Any(v => v.Forms == "Laboratory") == false)
                            {
                                foreach (var itemLaboratoryCategory in getOldManagement.LaboratoryCategories)
                                {
                                    var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = item.Name, Forms = "Laboratory", Categorys = itemLaboratoryCategory.Id.ToString() };
                                    _db.TempManagements.Add(inputCategory);
                                }
                            }
                            if (_db.TempManagements.Any(v => v.Forms == "MedicalImaging") == false)
                            {
                                foreach (var itemMedicalImagingCategory in getOldManagement.MedicalImagingCategories)
                                {
                                    var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = item.Name, Forms = "MedicalImaging", Categorys = itemMedicalImagingCategory.Id.ToString() };
                                    _db.TempManagements.Add(inputCategory);
                                }
                            }
                            if (_db.TempManagements.Any(v => v.Forms == "Prescription") == false)
                            {
                                foreach (var itemPrescriptionCategory in getOldManagement.PrescriptionCategories)
                                {
                                    var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = item.Name, Forms = "Prescription", Categorys = itemPrescriptionCategory.Id.ToString() };
                                    _db.TempManagements.Add(inputCategory);
                                }
                            }
                            if (_db.TempManagements.Any(v => v.Forms == "VariousDocument") == false)
                            {
                                foreach (var itemVariousDocumentCategory in getOldManagement.VariousDocumentCategories)
                                {
                                    var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = item.Name, Forms = "VariousDocument", Categorys = itemVariousDocumentCategory.Id.ToString() };
                                    _db.TempManagements.Add(inputCategory);
                                }
                            }

                            _db.SaveChanges();
                        }

                        else
                        {
                            var btn = new Button
                            {
                                Size = new Size(180, 90),
                                Text = item.Name,
                                Name = item.Id.ToString(),
                                BackColor = Color.LimeGreen,
                                Font = new Font("November", 12)
                            };

                            var input = new TempManagement() { Categorys = item.Id.ToString(), Forms = item.Name, Services = item.Name, WorkerId = acc.WorkerId };
                            _db.TempManagements.Add(input);
                            _db.SaveChanges();
                            flpn.Controls.Add(btn);
                            btn.Click += RemoveService_Click;
                        }
                    }
                    else
                    {
                        var chkTemp = _db.TempManagements.Any(v => v.Categorys == item.Id.ToString());
                        if (chkTemp)
                        {
                            var btn = new Button
                            {
                                Size = new Size(180, 90),
                                Text = item.Name,
                                Name = item.Id.ToString(),
                                BackColor = Color.LimeGreen,
                                Font = new Font("November", 12)
                            };

                            flpn.Controls.Add(btn);
                            btn.Click += RemoveService_Click;
                        }
                        else
                        {
                            var btn = new Button
                            {
                                Location = new Point(3, 3),
                                Size = new Size(180, 90),
                                Text = item.Name,
                                Name = item.Id.ToString(),
                                BackColor = Color.Khaki,
                                Font = new Font("November", 12)
                            };

                            flpn.Controls.Add(btn);
                            btn.Click += TakeService_Click;
                        }
                    }
                }
                else
                {
                    var chkAcc = _db.TempManagements.Any(v => v.Categorys == item.Id.ToString());

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

                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(180, 90),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12)
                        };

                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
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

            if (getText == "Medical's Form")
            {
                var categorySelection = new CategorySelection(){Account = _account};
                categorySelection.ShowDialog();
            }

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
            var getText = check.Text;


            if (getText == "Medical's Form")
            {
                var categorySelection = new CategorySelection();
                categorySelection.ShowDialog();
            }

            var delete = _db.TempManagements.First(v => v.Categorys == getName);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            var form = (Managements)Application.OpenForms["Managements"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ButtonSelectForm(_account));
            }
        }

        public void ClearTemp()
        {
            var clear = _db.TempManagements;
            _db.TempManagements.RemoveRange(clear);
            _db.SaveChanges();
        }

        public object Search_WorkerHasAccount(string search)
        {
           var bs2 = new BindingSource();

            var searchs = _db.Accounts.Where(v=>v.Worker.Position!="Admin").Where(v=>v.Worker.Hire).Where(v => v.Worker.Name.Contains(search) ||
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

        private void DeleteManagement(Hospital_Entity_Framework.Account acc)
        {
            var getManagement = _db.Managements.FirstOrDefault(v => v.AccountId == acc.Id);
            if (getManagement != null)
            {
                foreach (var item in getManagement.ConsultationCategories)
                {
                    getManagement.ConsultationCategories.Remove(item);
                }
                foreach (var item in getManagement.LaboratoryCategories)
                {
                    getManagement.LaboratoryCategories.Remove(item);
                }
                foreach (var item in getManagement.MedicalImagingCategories)
                {
                    getManagement.MedicalImagingCategories.Remove(item);
                }
                foreach (var item in getManagement.PrescriptionCategories)
                {
                    getManagement.PrescriptionCategories.Remove(item);
                }
                foreach (var item in getManagement.VariousDocumentCategories)
                {
                    getManagement.VariousDocumentCategories.Remove(item);
                }
                foreach (var item in getManagement.Forms)
                {
                    getManagement.Forms.Remove(item);
                }
                _db.Managements.Remove(getManagement);
                _db.SaveChanges();
            }
        }

        public void DeleteManagementAndAccount(Hospital_Entity_Framework.Account acc)
        {
            DeleteManagement(acc);
            _db.Accounts.Remove(acc);
            _db.SaveChanges();
        }

        public void SubmitManagement(Hospital_Entity_Framework.Account acc)
        {
            
        }

        public TabPage TabConsultation(Hospital_Entity_Framework.Account acc,CategorySelection categorySelection)
        {
            var tab=new TabPage(){AutoScroll = true,Text = @"Consultation"};
            var flpn = new FlowLayoutPanel() {Dock = DockStyle.Fill, AutoScroll = true};
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;
        
            var getTemp = _db.TempManagements.Where(v => v.Services=="Medical's Form");
            var getCategory = _db.ConsultationCategories;
            foreach (var itemCategory in getCategory)
            {
                if (getTemp.Any(v => v.Categorys == itemCategory.Id.ToString()))
                {
                    var btn = new Button
                    {
                        Size = new Size(180, 90),
                        Text = itemCategory.Name,
                        Name = itemCategory.Id.ToString(),
                        BackColor = Color.LimeGreen,
                        Font = new Font("November", 12),
                        Tag = "Consultation"
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += RemoveCategory_Click;
                }
                else
                {
                    var btn = new Button
                    {
                        Location = new Point(3, 3),
                        Size = new Size(180, 90),
                        Text = itemCategory.Name,
                        Name = itemCategory.Id.ToString(),
                        BackColor = Color.Khaki,
                        Font = new Font("November", 12),
                        Tag = "Consultation"
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += TakeCategory_Click;
                }
            }

            tab.Controls.Add(flpn);

            return tab;
        }

        private void TakeCategory_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            var getName = check.Name;
            var getTag = check.Tag;

            var insert = new TempManagement() { WorkerId = this._account.WorkerId, Categorys = getName, Forms = "Medical's Form", Services = getTag.ToString() };
            _db.TempManagements.Add(insert);
            _db.SaveChanges();

            _categorySelection.tabCategory.Controls.Clear();
            _categorySelection.tabCategory.Controls.AddRange(new Control[]{TabConsultation(_account,_categorySelection)});
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            var getName = check.Name;

            var delete = _db.TempManagements.Where(v=>v.Services=="Medical's Form").First(v=>v.Categorys==getName);
            _db.TempManagements.Add(delete);
            _db.SaveChanges();

            _categorySelection.Controls.Clear();
            _categorySelection.Controls.AddRange(new Control[] { TabConsultation(_account, _categorySelection) });
        }
    }
}
