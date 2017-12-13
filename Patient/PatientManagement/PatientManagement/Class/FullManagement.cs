﻿using System;
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
                    var chk = _db.TempManagements.Where(v=>v.Forms==item.Name).Any(v=>v.Services==item.Name);
                    if (chk)
                    {
                        var chkAcc = _db.TempManagements.Where(v => v.Forms == item.Name)
                            .Any(v => v.Services == item.Name);

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
                    else
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

                                if (_db.TempManagements.Any(v => v.Services == "Consultation") == false)
                                {
                                    foreach (var itemConsultationCategory in getOldManagement.ConsultationCategories)
                                    {
                                        var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = "Consultation", Forms = item.Name, Categorys = itemConsultationCategory.Id.ToString() };
                                        _db.TempManagements.Add(inputCategory);
                                    }
                                }

                                if (_db.TempManagements.Any(v => v.Services == "Laboratory") == false)
                                {
                                    foreach (var itemLaboratoryCategory in getOldManagement.LaboratoryCategories)
                                    {
                                        var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = "Laboratory", Forms = item.Name, Categorys = itemLaboratoryCategory.Id.ToString() };
                                        _db.TempManagements.Add(inputCategory);
                                    }
                                }
                                if (_db.TempManagements.Any(v => v.Services == "MedicalImaging") == false)
                                {
                                    foreach (var itemMedicalImagingCategory in getOldManagement.MedicalImagingCategories)
                                    {
                                        var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = "MedicalImaging", Forms = item.Name, Categorys = itemMedicalImagingCategory.Id.ToString() };
                                        _db.TempManagements.Add(inputCategory);
                                    }
                                }
                                if (_db.TempManagements.Any(v => v.Services == "Prescription") == false)
                                {
                                    foreach (var itemPrescriptionCategory in getOldManagement.PrescriptionCategories)
                                    {
                                        var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = "Prescription", Forms = item.Name, Categorys = itemPrescriptionCategory.Id.ToString() };
                                        _db.TempManagements.Add(inputCategory);
                                    }
                                }
                                if (_db.TempManagements.Any(v => v.Services == "VariousDocument") == false)
                                {
                                    foreach (var itemVariousDocumentCategory in getOldManagement.VariousDocumentCategories)
                                    {
                                        var inputCategory = new TempManagement() { WorkerId = acc.WorkerId, Services = "VariousDocument", Forms = item.Name, Categorys = itemVariousDocumentCategory.Id.ToString() };
                                        _db.TempManagements.Add(inputCategory);
                                    }
                                }
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
                                flpn.Controls.Add(btn);
                                btn.Click += RemoveService_Click;
                            }
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
                    var chkAcc = _db.TempManagements.Where(v => v.Forms == item.Name)
                        .Any(v => v.Categorys == item.Id.ToString());

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
                var categorySelection = new CategorySelection() {Account = _account};
                categorySelection.ShowDialog();
                var insert = new TempManagement()
                {
                    WorkerId = _account.WorkerId,
                    Categorys = getName,
                    Forms = getText,
                    Services = getText
                };
                _db.TempManagements.Add(insert);
                _db.SaveChanges();
            }

            else
            {
                var insert = new TempManagement()
                {
                    WorkerId = _account.WorkerId,
                    Categorys = getName,
                    Forms = getText,
                    Services = getText
                };
                _db.TempManagements.Add(insert);
                _db.SaveChanges();
            }
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
                if (_db.TempManagements.Where(v=>v.Forms=="Medical's Form").Any(v=>v.Services=="Consultation"||v.Services=="Laboratory"||
                    v.Services=="MedicalImaging"||v.Services=="Prescription"||v.Services=="VariousDocument")==false)
                {
                    var delete = _db.TempManagements.Where(v => v.Services == getText).First(v => v.Categorys == getName);
                    _db.TempManagements.Remove(delete);
                    _db.SaveChanges();
                }
            }

            else
            {
                var delete = _db.TempManagements.Where(v=>v.Services==getText).First(v => v.Categorys == getName);
                _db.TempManagements.Remove(delete);
                _db.SaveChanges();
            }

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
                if (getManagement.ConsultationCategories != null)
                {
                    foreach (var item in getManagement.ConsultationCategories.ToList())
                    {
                        var getItem = _db.ConsultationCategories.FirstOrDefault(v => v.Id == item.Id);
                        getManagement.ConsultationCategories.Remove(getItem);
                    }
                }
                if (getManagement.LaboratoryCategories != null)
                {
                    foreach (var item in getManagement.LaboratoryCategories.ToList())
                    {
                        var getItem = _db.LaboratoryCategories.First(v => v.Id == item.Id);
                        getManagement.LaboratoryCategories.Remove(getItem);
                    }
                }
                if (getManagement.MedicalImagingCategories != null)
                {
                    foreach (var item in getManagement.MedicalImagingCategories.ToList())
                    {
                        var getItem = _db.MedicalImagingCategories.First(v => v.Id == item.Id);
                        getManagement.MedicalImagingCategories.Remove(getItem);
                    }
                }
                if (getManagement.PrescriptionCategories != null)
                {
                    foreach (var item in getManagement.PrescriptionCategories.ToList())
                    {
                        var getItem = _db.PrescriptionCategories.First(v => v.Id == item.Id);
                        getManagement.PrescriptionCategories.Remove(getItem);
                    }
                }
                if (getManagement.VariousDocumentCategories != null)
                {
                    foreach (var item in getManagement.VariousDocumentCategories.ToList())
                    {
                        var getItem = _db.VariousDocumentCategories.First(v => v.Id == item.Id);
                        getManagement.VariousDocumentCategories.Remove(getItem);
                    }
                }
                if (getManagement.Forms != null)
                {
                    foreach (var item in getManagement.Forms.ToList())
                    {
                        var getItem = _db.Forms.First(v => v.Id == item.Id);
                        getManagement.Forms.Remove(getItem);
                    }
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
            DeleteManagement(acc);

            var newManagement=new Hospital_Entity_Framework.Management(){AccountId = acc.Id};
            _db.Managements.Add(newManagement);
            _db.SaveChanges();

            var getTemp = _db.TempManagements;
            var getManagement = _db.Managements.First(v => v.AccountId == acc.Id);
            foreach (var itemTemp in getTemp)
            {
                if (itemTemp.Forms == "Worker's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Patient's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "CheckIn's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Management's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Sample's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Category's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Admin's Form")
                {
                    var get = Convert.ToInt32(itemTemp.Categorys);
                    var chk = _db.Forms.First(v => v.Id == get);
                    getManagement.Forms.Add(chk);
                }
                if (itemTemp.Forms == "Medical's Form")
                {
                    if (itemTemp.Services == "Consultation")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.ConsultationCategories.First(v => v.Id == get );
                        getManagement.ConsultationCategories.Add(chk);
                    }
                    if (itemTemp.Services == "Laboratory")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.LaboratoryCategories.First(v => v.Id == get);
                        getManagement.LaboratoryCategories.Add(chk);
                    }
                    if (itemTemp.Services == "MedicalImaging")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.MedicalImagingCategories.First(v => v.Id == get);
                        getManagement.MedicalImagingCategories.Add(chk);
                    }
                    if (itemTemp.Services == "Prescription")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.PrescriptionCategories.First(v => v.Id == get);
                        getManagement.PrescriptionCategories.Add(chk);
                    }
                    if (itemTemp.Services == "VariousDocument")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.VariousDocumentCategories.First(v => v.Id == get);
                        getManagement.VariousDocumentCategories.Add(chk);
                    }
                    if (itemTemp.Services == "Medical's Form")
                    {
                        var get = Convert.ToInt32(itemTemp.Categorys);
                        var chk = _db.Forms.First(v => v.Id == get);
                        getManagement.Forms.Add(chk);
                    }
                }
            }
            _db.SaveChanges();
        }

        public TabPage TabConsultation(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var tab = new TabPage() { AutoScroll = true, Text = @"Consultation", Name = @"Consultation" };
            var flpn = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;

            var getTemp = _db.TempManagements.Where(v => v.Forms == "Medical's Form").Where(v => v.Services == "Consultation");
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

        public TabPage TabLaboratory(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var tab = new TabPage() { AutoScroll = true, Text = @"Laboratory",Name = @"Laboratory"};
            var flpn = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;

            var getTemp = _db.TempManagements.Where(v => v.Forms == "Medical's Form").Where(v => v.Services == "Laboratory");
            var getCategory = _db.LaboratoryCategories;
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
                        Tag = "Laboratory"
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
                        Tag = "Laboratory"
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += TakeCategory_Click;
                }
            }

            tab.Controls.Add(flpn);

            return tab;
        }

        public TabPage TabMedicalImaging(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var tab = new TabPage() { AutoScroll = true, Text = @"MedicalImaging" ,Name = @"MedicalImaging"};
            var flpn = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;

            var getTemp = _db.TempManagements.Where(v => v.Forms == "Medical's Form").Where(v => v.Services == "MedicalImaging");
            var getCategory = _db.MedicalImagingCategories;
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
                        Tag = "MedicalImaging"
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
                        Tag = "MedicalImaging"
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += TakeCategory_Click;
                }
            }

            tab.Controls.Add(flpn);

            return tab;
        }

        public TabPage TabPrescription(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var tab = new TabPage() { AutoScroll = true, Text = @"Prescription",Name = @"Prescription"};
            var flpn = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;

            var getTemp = _db.TempManagements.Where(v => v.Forms == "Medical's Form").Where(v => v.Services == "Prescription");
            var getCategory = _db.PrescriptionCategories;
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
                        Tag = "Prescription"
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
                        Tag = "Prescription"
                    };

                    flpn.Controls.Add(btn);
                    btn.Click += TakeCategory_Click;
                }
            }

            tab.Controls.Add(flpn);

            return tab;
        }

        public TabPage TabVariousDocument(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var tab = new TabPage() { AutoScroll = true, Text = @"VariousDocument",Name = @"VariousDocument"};
            var flpn = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };
            flpn.Controls.Clear();
            _categorySelection = null;
            _categorySelection = categorySelection;
            _account = acc;

            var getTemp = _db.TempManagements.Where(v => v.Forms == "Medical's Form").Where(v => v.Services == "VariousDocument");
            var getCategory = _db.VariousDocumentCategories;
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
                        Tag = "VariousDocument"
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
                        Tag = "VariousDocument"
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
            var getWorkerId = _db.TempManagements.First().WorkerId;

            var insert = new TempManagement() { WorkerId = getWorkerId, Categorys = getName, Forms = "Medical's Form", Services = getTag.ToString() };
            _db.TempManagements.Add(insert);
            _db.SaveChanges();

            _categorySelection.tabCategory.Controls.Clear();
            _categorySelection.Account = _account;
            _categorySelection.tabCategory.Controls.AddRange(new Control[]
            {
                TabConsultation(_account,_categorySelection),
                TabLaboratory(_account,_categorySelection),
                TabMedicalImaging(_account,_categorySelection),
                TabPrescription(_account,_categorySelection),
                TabVariousDocument(_account,_categorySelection)
            });
            var get = getTag.ToString();
            _categorySelection.tabCategory.Enabled = false;
            _categorySelection.tabCategory.SelectTab(get);
            _categorySelection.tabCategory.Enabled = true;
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            var getName = check.Name;
            var getTag = check.Tag;

            var delete = _db.TempManagements.Where(v=>v.Forms=="Medical's Form").Where(v=>v.Services==getTag.ToString()).First(v=>v.Categorys==getName);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            _categorySelection.tabCategory.Controls.Clear();
            _categorySelection.Account = _account;
            _categorySelection.tabCategory.Controls.AddRange(new Control[]  {
                TabConsultation(_account,_categorySelection),
                TabLaboratory(_account,_categorySelection),
                TabMedicalImaging(_account,_categorySelection),
                TabPrescription(_account,_categorySelection),
                TabVariousDocument(_account,_categorySelection)
            });
            var get = getTag.ToString();
            _categorySelection.tabCategory.Enabled = false;
            _categorySelection.tabCategory.SelectTab(get);
            _categorySelection.tabCategory.Enabled = true;
        }

        public void ClearCatergory(Hospital_Entity_Framework.Account acc, CategorySelection categorySelection)
        {
            var chk = _db.TempManagements.Where(v => v.Forms == "Medical's Form");

            foreach (var item in chk.Where(v=>v.Services == "Consultation"))
            {
                _db.TempManagements.Remove(item);
            }
            foreach (var item in chk.Where(v => v.Services == "Laboratory"))
            {
                _db.TempManagements.Remove(item);
            }
            foreach (var item in chk.Where(v => v.Services == "MedicalImaging"))
            {
                _db.TempManagements.Remove(item);
            }
            foreach (var item in chk.Where(v => v.Services == "Prescription"))
            {
                _db.TempManagements.Remove(item);
            }
            foreach (var item in chk.Where(v => v.Services == "VariousDocument"))
            {
                _db.TempManagements.Remove(item);
            }
            _db.SaveChanges();

            categorySelection.tabCategory.Controls.Clear();
            categorySelection.Account = _account;
            categorySelection.tabCategory.Controls.AddRange(new Control[]  {
                TabConsultation(acc,categorySelection),
                TabLaboratory(acc,categorySelection),
                TabMedicalImaging(acc,categorySelection),
                TabPrescription(acc,categorySelection),
                TabVariousDocument(acc,categorySelection)
            });
        }
    }
}
