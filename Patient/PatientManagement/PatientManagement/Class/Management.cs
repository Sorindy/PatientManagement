using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;


namespace PatientManagement.Class
{
    public class Management
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private IStatus _status;
        private ICategoryStatus _categoryStatus;

        public void Insert(string id, string accId)
        {
            var insert=new Hospital_Entity_Framework.Management(){Id = id,AccountId = accId};

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

                bs.DataSource = show.Select(s => new { s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName }).ToList();

            return bs;
        }

        public object Search_WorkerHasAccount(string search)
        {
            BindingSource bs2 = new BindingSource();

            var searchs = _db.Accounts.Where(v => v.Worker.Id.Contains(search) || v.Worker.Name.Contains(search) ||
                                                  v.Worker.Position.Contains(search));

            bs2.DataSource = searchs
                .Select(s => new {s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName}).ToList();

            return bs2;
        }

        public string AutoId()
        {
            var management=new Hospital_Entity_Framework.Management();
            try
            {
                var getLastId = _db.Managements.OrderByDescending(m => m.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(10));
                num += 1;
                management.Id = string.Concat("Management", num);
            }
            catch
            {
                management.Id = "Management1";
            }
            return management.Id;
        }

        private FlowLayoutPanel MedicalPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            _status = new ConsultationStatus();
            var showConsultation = _status.ShowCategoryBox();
            _status = new LaboratoryStatus();
            var showLaboratory = _status.ShowCategoryBox();
            _status = new MedicalImagingStatus();
            var showMedicalImaging = _status.ShowCategoryBox();
            _status = new PrescriptionStatus();
            var showPrescription = _status.ShowCategoryBox();
            _status = new VariousDocumentStatus();
            var showVariousDoc = _status.ShowCategoryBox();

            panel.Controls.AddRange(new Control[] { showConsultation, showLaboratory, showMedicalImaging, showPrescription, showVariousDoc });
            return panel;
        }

        private FlowLayoutPanel WorkerPanel()
        {
            var panel = new FlowLayoutPanel();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.Location = new Point(6, 50);
            panel.Size = new Size(526, 378);

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"Worker's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("Worker's Form");
            flpn.Controls.Add(checkListBox);
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

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"Category's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("Category's Form");
            flpn.Controls.Add(checkListBox);
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

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"Patient's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("Patient's Form");
            flpn.Controls.Add(checkListBox);
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

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"CheckIn's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("CheckIn's Form");
            flpn.Controls.Add(checkListBox);
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

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"Management's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("Management's Form");
            flpn.Controls.Add(checkListBox);
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

            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox { Text = @"Admin's Form" };
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            checkListBox.Items.Add("Admin's Form");
            flpn.Controls.Add(checkListBox);
            groupBox.Controls.Add(flpn);

            panel.Controls.Add(groupBox);

            return panel;
        }

        public FlowLayoutPanel ChoosenFormPanel(string str)
        {
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

        public void CheckedItems(string workerId, string form, string service, string category, bool check)
        {
            var checkTemp = _db.TempManagements.FirstOrDefault(v => v.Categorys==category);

            if (checkTemp!=null){}
            else{
                var insertTemp = new TempManagement()
                {
                    Id = AutoIdChecked(),
                    WorkerId = workerId,
                    Forms = form,
                    Categorys = category,
                    Services = service,
                    Status = check
                };
                _db.TempManagements.AddOrUpdate(insertTemp);
                _db.SaveChanges();
            }
        }

        private string AutoIdChecked()
        {
            var management = new TempManagement();
            try
            {
                var getLastId = _db.TempManagements.OrderByDescending(m => m.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(4));
                num += 1;
                management.Id = string.Concat("Temp", num);
            }
            catch
            {
                management.Id = "Temp1";
            }
            return management.Id;
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

                //foreach (var item in tabControl.TabPages)
                //{
                //    var getCheckedItem = from v in _db.TempManagements
                //        where v.Forms == formTab
                //        select new
                //        {
                //            v.Categorys
                //        };
                //    foreach (var value in getCheckedItem)
                //    {
                //        checkListBox.Items.Add(value,true);                        
                //    }
                    flpn.Controls.Clear();
                //    flpn.Controls.Add(checkListBox);
                //    tabControl.TabPages[formTab].Controls.Add(flpn);


            }

            //foreach (var getitemsChecked in tabControl.TabPages)
            //{
            //    var checkListBox = new CheckedListBox { Location = new Point(3, 3), Size = new Size(503, 143), Name = @"ChecklistBoxItems" };
            //    var checkedItem = _db.TempManagements.Where(v => v.Forms == (string) getitemsChecked)
            //        .Select(v => v.Categorys);
            //    foreach (var items in checkedItem)
            //    {
            //        checkListBox.Items.Add(items, true);
            //        flpn.Controls.Add(checkListBox);
            //    }


            //    tabControl.TabPages[getitemsChecked.ToString()].Controls.Add(flpn);
        //}

        return tabControl;
        }

        public void SubmitManagement()
        {
            var getWorkerId = _db.TempManagements.Select(v => v.WorkerId);
            var getAccId = _db.Accounts.Where(v => v.WorkerId == getWorkerId.ToString()).Select(v=>v.Id);
            var getConsultation = _db.TempManagements.Single(v => v.Services == "Consutation");
            var getLaboratory = _db.TempManagements.Single(v => v.Services == "Laboratory");
            var getMedicalImaging = _db.TempManagements.Single(v => v.Services == "MedicalImaging");
            var getPrescription = _db.TempManagements.Single(v => v.Services == "Presciption");
            var getVariousDocument = _db.TempManagements.Single(v => v.Services == "VariousDocument");
            Insert(AutoId(),getAccId.ToString());

            if (getConsultation != null)
            {
                _status = new ConsultationStatus();
                _status.Insert(_status.AutoId(), true);
            }
            if (getLaboratory != null)
            {
                _status=new LaboratoryStatus();
                _status.Insert(_status.AutoId(),true);
            }
            if (getMedicalImaging != null)
            {
                _status=new MedicalImagingStatus();
                _status.Insert(_status.AutoId(),true);
            }
            if (getPrescription != null)
            {
                _status=new PrescriptionStatus();
                _status.Insert(_status.AutoId(),true);
            }
            if (getVariousDocument != null)
            {
                _status = new VariousDocumentStatus();
                _status.Insert(_status.AutoId(), true);
            }
        }

    }

}
