using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;


namespace PatientManagement.Class
{
    public class Management
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private int _workerId;

        private void Insert(int accId)
       {
            var insert=new Hospital_Entity_Framework.Management(){AccountId = accId};

            _db.Managements.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(Hospital_Entity_Framework.Management management)
        {
            var delete = _db.Managements.Single(v => v.Id == management.Id);

            _db.Managements.Remove(delete);
            _db.SaveChanges();
        }

        public object Show_Control()
        {
            BindingSource bs=new BindingSource();
            var forms = new[] {"Worker's Form","Patient's Form","CheckIn's Form","Management's Form","Admin's Form","Medical's Form",
                    "Category's Form"};

                bs.DataSource = forms.ToList();
            return bs;
        }

        public object Show_WorkerHasAccount()
        {
            var bs = new BindingSource();
            var show = _db.Accounts;

            bs.DataSource = show.Select(s => new
                {
                    s.Worker.Id,
                    s.Worker.Name,
                    s.Worker.Gender,
                    s.Worker.Position,
                    s.UserName
                }).ToList();

            return bs;
        }

        public object Search_WorkerHasAccount(string search)
        {
            BindingSource bs2 = new BindingSource();

            var searchs = _db.Accounts.Where(v => v.Worker.Name.Contains(search) ||
                                                  v.Worker.Position.Contains(search));

            bs2.DataSource = searchs
                .Select(s => new {s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName}).ToList();

            return bs2;
        }

        internal FlowLayoutPanel MedicalPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var showConsultation= new ConsultationCategory();
            var showLaboratory =new LaboratoryCategory();
            var showMedicalImaging = new MedicalImagingCategory();
            var showPrescription =new PrescriptionCategory();
            var showVariousDoc = new VariousDocumentCategory();

            panel.Controls.AddRange(new Control[] { showConsultation.ShowCategoryBox(_workerId),
                                                    showLaboratory.ShowCategoryBox(_workerId),
                                                    showMedicalImaging.ShowCategoryBox(_workerId),
                                                    showPrescription.ShowCategoryBox(_workerId),
                                                    showVariousDoc.ShowCategoryBox(_workerId)
                                                    });
            showPrescription.Management = this;
            showVariousDoc.Management = this;
            showConsultation.Management = this;
            showLaboratory.Management = this;
            showMedicalImaging.Management = this;
            var form = (ManagementForm)Application.OpenForms["ManagementForm"];
            if (form != null)
            {
                var gbo = form.gboControlName;
                gbo.Controls.Clear();
                gbo.Controls.Add(panel);
            }
            return null;
        }

        private FlowLayoutPanel WorkerPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"Worker's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabases = singleOrDefault != null && singleOrDefault.Forms.
                                     Any(v=>v.Name=="Worker's Form");

            if (checkDatabases)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Worker's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Worker's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Worker's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Worker's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Worker's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Worker's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        private FlowLayoutPanel CategoryPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"Category's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabase = singleOrDefault != null && singleOrDefault.Forms
                                    .Any(v => v.Name == "Category's Form");

            if (checkDatabase)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Category's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Category's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Category's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }
            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Category's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Category's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Category's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        private FlowLayoutPanel PatientPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"Patient's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabase = singleOrDefault != null && singleOrDefault.Forms
                                    .Any(v => v.Name == "Patient's Form");

            if (checkDatabase)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Patient's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Patient's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Patient's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }
            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Patient's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Patient's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Patient's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        private FlowLayoutPanel CheckInPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"CheckIn's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabase = singleOrDefault != null && singleOrDefault.Forms
                                    .Any(v => v.Name == "CheckIn's Form");

            if (checkDatabase)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "CheckIn's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"CheckIn's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"CheckIn's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }
            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "CheckIn's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"CheckIn's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"CheckIn's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        private FlowLayoutPanel ManagementPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"Management's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabase = singleOrDefault != null && singleOrDefault.Forms
                                    .Any(v => v.Name == "Management's Form");

            if (checkDatabase)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Management's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Management's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Management's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }
            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Management's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Management's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Management's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        private FlowLayoutPanel AdminPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var groupBox = new GroupBox { Text = @"Admin's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == _workerId);
            var checkDatabase = singleOrDefault != null && singleOrDefault.Forms
                                    .Any(v => v.Name == "Admin's Form");

            if (checkDatabase)
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Admin's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Admin's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Admin's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }
            else
            {
                var checking = _db.TempManagements.Any(v => v.Forms == "Admin's Form");
                if (checking)
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Admin's Form",
                        Checked = true
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormUnChecked;
                }
                else
                {
                    var checkBox = new CheckBox
                    {
                        Size = new Size(508, 54),
                        Text = @"Admin's Form",
                        Checked = false
                    };
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += FormChecked;
                }
            }

            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        public FlowLayoutPanel ChoosenFormPanel(string str,int workerId)
        {
            _workerId = workerId;
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();

            if (str == "Worker's Form")
            {
                panel = WorkerPanel();
            }
            if (str == "Patient's Form")
            {
                panel = PatientPanel();
            }
            if (str == "CheckIn's Form")
            {
                panel = CheckInPanel();
            }
            if (str == "Management's Form")
            {
                panel = ManagementPanel();
            }
            if (str == "Admin's Form")
            {
                panel = AdminPanel();
            }
            if (str == "Medical's Form")
            {
                panel = MedicalPanel();
            }
            if (str == "Category's Form")
            {
                panel = CategoryPanel();
            }

            return panel;
        }

        public void CheckedItems(int workerId, string form, string service, string category, bool check)
        {
            var checkTemp = _db.TempManagements.FirstOrDefault(v => v.Categorys==category);

            if (checkTemp!=null){}
            else{
                var insertTemp = new TempManagement()
                {
                    WorkerId = workerId,
                    Forms = form,
                    Categorys = category,
                    Services = service,
                };
                _db.TempManagements.AddOrUpdate(insertTemp);
                _db.SaveChanges();
            }
        }

        public void ClearTemp()
        {
            var clear = _db.TempManagements;
            _db.TempManagements.RemoveRange(clear);
            _db.SaveChanges();
        }

        public TabControl TabControlPreview()
        {
            var tabControl = new TabControl
            {
                Size = new Size(526, 196),
                Location = new Point(6, 29),
                Name = @"tabControlPreview"
            };
            tabControl.Controls.Clear();
            var flpn = new FlowLayoutPanel
            {
                Size = new Size(506, 146),
                Location = new Point(6, 6),
                Name = @"flowCheckedItems"
            };
            var checkListBox = new CheckedListBox
            {
                Location = new Point(3, 3),
                Size = new Size(503, 143),
                Name = @"ChecklistBoxItems"
            };
            checkListBox.Controls.Clear();

            var getCheckedItems = _db.TempManagements.Select(v => v.Forms);

            foreach (var formTab in getCheckedItems)
            {
                tabControl.TabPages.Add(formTab);
                flpn.Controls.Clear();
            }
        return tabControl;
        }

        public void SubmitManagement(int workerId)
        {
            var getAccId = _db.Accounts.First(v => v.WorkerId == workerId).Id;
            var deleteOldManagement = _db.Managements.FirstOrDefault(v => v.AccountId == getAccId);
            if (deleteOldManagement != null)
            {
                var delConsultaion= deleteOldManagement.ConsultationCategories;
                if (delConsultaion != null)
                {
                    foreach (var item in delConsultaion)
                    {
                        _db.Managements.FirstOrDefault(v => v.AccountId == getAccId).ConsultationCategories.Remove(item);
                        _db.SaveChanges();
                    }
                }
                var delLaboratory = deleteOldManagement.LaboratoryCategories;
                if (delLaboratory != null)
                {
                    foreach (var item in delLaboratory)
                    {
                        _db.Managements.FirstOrDefault(v => v.AccountId == getAccId).LaboratoryCategories.Remove(item);
                        _db.SaveChanges();
                    }
                }
                var delMedicalImaging = deleteOldManagement.MedicalImagingCategories;
                if (delMedicalImaging != null)
                {
                    foreach (var item in delMedicalImaging)
                    {
                        _db.Managements.FirstOrDefault(v => v.AccountId == getAccId).MedicalImagingCategories.Remove(item);
                        _db.SaveChanges();
                    }
                }
                var delPrescription = deleteOldManagement.PrescriptionCategories;
                if (delPrescription != null)
                {
                    foreach (var item in delPrescription)
                    {
                        _db.Managements.FirstOrDefault(v => v.AccountId == getAccId).PrescriptionCategories.Remove(item);
                        _db.SaveChanges();
                    }
                }
                var delVariousdocument = deleteOldManagement.VariousDocumentCategories;
                if (delVariousdocument != null)
                {
                    foreach (var item in delVariousdocument)
                    {
                        _db.Managements.FirstOrDefault(v => v.AccountId == getAccId).VariousDocumentCategories.Remove(item);
                        _db.SaveChanges();
                    }
                }
                _db.Managements.Remove(deleteOldManagement);
                _db.SaveChanges();
            }
            var getConsultation = _db.TempManagements.Where(v => v.Services == "Consutation");
            var checkConsultation = _db.TempManagements.Any(v => v.Services == "Consutation");
            var getLaboratory = _db.TempManagements.Where(v => v.Services == "Laboratory");
            var checkLaboratory = _db.TempManagements.Any(v => v.Services == "Laboratory");
            var getMedicalImaging = _db.TempManagements.Where(v => v.Services == "MedicalImaging");
            var checkMedicalImaging = _db.TempManagements.Any(v => v.Services == "MedicalImaging");
            var getPrescription = _db.TempManagements.Where(v => v.Services == "Presciption");
            var checkPrescription = _db.TempManagements.Any(v => v.Services == "Presciption");
            var getVariousDocument = _db.TempManagements.Where(v => v.Services == "VariousDocument");
            var checkVariousDocument = _db.TempManagements.Any(v => v.Services == "VariousDocument");
            var checkWorkerForm = _db.TempManagements.Any(v => v.Forms == "Worker's Form");
            var checkPatientForm = _db.TempManagements.Any(v => v.Forms == "Patient's Form");
            var checkCheckInForm = _db.TempManagements.Any(v => v.Forms == "CheckIn's Form");
            var checkManagementForm = _db.TempManagements.Any(v => v.Forms == "Management's Form");
            var checkCategoryForm = _db.TempManagements.Any(v => v.Forms == "Category's Form");
            var checkAdminForm = _db.TempManagements.Any(v => v.Forms == "Admin's Form");

            Insert(getAccId);

            if (checkConsultation)
            {
                foreach (var item in getConsultation)
                {
                    var checkCategory = _db.ConsultationCategories.Single(v => v.Name == item.Categorys);
                    _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).ConsultationCategories.Add(checkCategory);
                    _db.SaveChanges();
                }                
            }
            if (checkLaboratory)
            {
                foreach (var item in getLaboratory)
                {
                    var checkCategory = _db.LaboratoryCategories.Single(v => v.Name == item.Categorys);
                    _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).LaboratoryCategories.Add(checkCategory);
                    _db.SaveChanges();
                }


            }
            if (checkMedicalImaging)
            {
                foreach (var item in getMedicalImaging)
                {
                    var checkCategory = _db.MedicalImagingCategories.Single(v => v.Name == item.Categorys);
                    _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).MedicalImagingCategories.Add(checkCategory);
                    _db.SaveChanges();
                }
            }
            if (checkPrescription)
            {
                foreach (var item in getPrescription)
                {
                    var checkCategory = _db.PrescriptionCategories.Single(v => v.Name == item.Categorys);
                    _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).PrescriptionCategories.Add(checkCategory);
                    _db.SaveChanges();
                }
            }
            if (checkVariousDocument)
            {
                foreach (var item in getVariousDocument)
                {
                    var checkCategory = _db.VariousDocumentCategories.Single(v => v.Name == item.Categorys);
                    _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).VariousDocumentCategories.Add(checkCategory);
                    _db.SaveChanges();
                }
            }
            if (checkWorkerForm)
            {
                var check = _db.Forms.Single(v => v.Name == "Worker's Form");
                _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).Forms.Add(check);
                _db.SaveChanges();
            }
            if(checkPatientForm)
            {
                var check = _db.Forms.Single(v => v.Name == "Patient's Form");
                _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).Forms.Add(check);
                _db.SaveChanges();
            }
            if(checkAdminForm)
            {
                var check = _db.Forms.Single(v => v.Name == "Admin's Form");
                _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).Forms.Add(check);
                _db.SaveChanges();
            }
            if(checkCategoryForm)
            {
                var check = _db.Forms.Single(v => v.Name == "Category's Form");
                _db.Managements.FirstOrDefault(v=>v.AccountId==getAccId).Forms.Add(check);
                _db.SaveChanges();
            }
            if(checkManagementForm)
            {
                var check = _db.Forms.Single(v => v.Name == "Management's Form");
                _db.Managements.FirstOrDefault(v =>v.AccountId==getAccId).Forms.Add(check);
                _db.SaveChanges();
            }
            if(checkCheckInForm)
            {
                var check = _db.Forms.Single(v => v.Name == "CheckIn's Form");

                _db.Managements.FirstOrDefault(v => v.AccountId==getAccId).Forms.Add(check);

                _db.SaveChanges();
            }
        }

        private void Reload(string getText)
        {
            if (getText == "Worker's Form")
            {
                var form = (ManagementForm)Application.OpenForms["ManagementForm"];
                if (form != null)
                {
                    var gbo = form.gboControlName;
                    gbo.Controls.Clear();
                    gbo.Controls.Add(ChoosenFormPanel("Worker's Form",_workerId));
                }
            }
            if (getText == "Admin's Form")
            {
                var form = (ManagementForm)Application.OpenForms["ManagementForm"];
                if (form != null)
                {
                    var gbo = form.gboControlName;
                    gbo.Controls.Clear();
                    gbo.Controls.Add(ChoosenFormPanel("Admin's Form",_workerId));
                }
            }
            if (getText == "Patient's Form")
            {
                var form = (ManagementForm)Application.OpenForms["ManagementForm"];
                if (form != null)
                {
                    var gbo = form.gboControlName;
                    gbo.Controls.Clear();
                    gbo.Controls.Add(ChoosenFormPanel("Patient's Form",_workerId));
                }
            }
            if (getText == "Management's Form")
            {
                var form = (ManagementForm)Application.OpenForms["ManagementForm"];
                if (form != null)
                {
                    var gbo = form.gboControlName;
                    gbo.Controls.Clear();
                    gbo.Controls.Add(ChoosenFormPanel("Management's Form",_workerId));
                }
            }
            if (getText == "Category's Form")
            {
                var form = (ManagementForm)Application.OpenForms["ManagementForm"];
                if (form != null)
                {
                    var gbo = form.gboControlName;
                    gbo.Controls.Clear();
                    gbo.Controls.Add(ChoosenFormPanel("Category's Form",_workerId));
                }
            }
        }

        private void FormChecked(object sender, EventArgs e)
        {
            var get = (CheckBox) sender;
            var getText = get.Text;
            var insert=new TempManagement{WorkerId = _workerId,Forms = getText,Services = getText,Categorys = getText};
            _db.TempManagements.Add(insert);
            _db.SaveChanges();

            Reload(getText);
        }

        private void FormUnChecked(object sender, EventArgs e)
        {
            var get = (CheckBox) sender;
            var getText = get.Text;
            var delete = _db.TempManagements.Single(v => v.Forms == getText);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            Reload(getText);
        }
    }

}
