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
        private IStatus _status;

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

        public void SubmitManagement(string workerId)
        {
            //var getWorkerId = _db.TempManagements.First(v => v.WorkerId==workerId).;
            string getAccId = _db.Accounts.First(v => v.WorkerId == workerId).Id;
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
            Insert(AutoId(),getAccId);

            if (checkConsultation)
            {
                _status = new ConsultationStatus();
                var id = _status.AutoId();
                _status.Insert(id, true);

                var service=new ServiceCategory();
                var consulCatStatus=new ConsultationCategoryStatus();
                foreach (var item in getConsultation)
                {
                    var catId = _db.ConsultationCategories.First(v => v.Name == item.Categorys).Id;
                    var concatId = consulCatStatus.AutoId();
                    consulCatStatus.Insert(concatId,catId,true);

                    service.Insert(id,concatId);
                }
                
            }
            if (checkLaboratory)
            {
                _status=new LaboratoryStatus();
                var id = _status.AutoId();
                _status.Insert(id, true);

                var service = new ServiceCategory();
                var labCatStatus = new LaboratoryCategoryStatus();
                foreach (var item in getLaboratory)
                {
                    var catId = _db.LaboratoryCategories.Where(v => v.Name == item.Categorys).Select(v => v.Id);
                    var concatId = labCatStatus.AutoId();
                    labCatStatus.Insert(concatId, catId.ToString(), true);

                    service.Insert(id, concatId);
                }


            }
            if (checkMedicalImaging)
            {
                _status=new MedicalImagingStatus();
                var id = _status.AutoId();
                _status.Insert(id, true);

                var service = new ServiceCategory();
                var medCatStatus = new MedicalImagingCategoryStatus();
                foreach (var item in getMedicalImaging)
                {
                    var catId = _db.MedicalImagingCategories.Where(v => v.Name == item.Categorys).Select(v => v.Id);
                    var concatId = medCatStatus.AutoId();
                    medCatStatus.Insert(concatId, catId.ToString(), true);

                    service.Insert(id, concatId);
                }
            }
            if (checkPrescription)
            {
                _status=new PrescriptionStatus();
                var id = _status.AutoId();
                _status.Insert(id, true);

                var service = new ServiceCategory();
                var presciptCatStatus = new PrescriptionCategoryStatus();
                foreach (var item in getPrescription)
                {
                    var catId = _db.PrescriptionCategories.Where(v => v.Name == item.Categorys).Select(v => v.Id);
                    var concatId = presciptCatStatus.AutoId();
                    presciptCatStatus.Insert(concatId, catId.ToString(), true);

                    service.Insert(id, concatId);
                }
            }
            if (checkVariousDocument)
            {
                _status = new VariousDocumentStatus();
                var id = _status.AutoId();
                _status.Insert(id, true);

                var service = new ServiceCategory();
                var vardocCatStatus = new VariousDocumentCategoryStatus();
                foreach (var item in getVariousDocument)
                {
                    var catId = _db.VariousDocumentCategories.Where(v => v.Name == item.Categorys).Select(v => v.Id);
                    var concatId = vardocCatStatus.AutoId();
                    vardocCatStatus.Insert(concatId, catId.ToString(), true);

                    service.Insert(id, concatId);
                }
            }
            _db.SaveChanges();
        }

    }

}
