using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class CheckIn
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();

        public void InsertWaiting(string id, string patientId, TimeSpan date)
        {
            var insert=new Hospital_Entity_Framework.WaitingList(){Id = id,PatientId = patientId,Time = date};

            _db.WaitingLists.Add(insert);
            _db.SaveChanges();
        }

        public void DeleteWaiting(string id)
        {
            var delete = _db.WaitingLists.Single(v => v.Id == id);

            _db.WaitingLists.Remove(delete);
            _db.SaveChanges();
        }

        public void UpdateWaiting(string id)
        {
            
        }

        public BindingSource ShowDatingList()
        {
            var bs=new BindingSource();

            var show = _db.Datings;
            bs.DataSource = show.ToList();

            return bs;
        }
  
        public FlowLayoutPanel ShowService()
        {
            var flpn = new FlowLayoutPanel
            {
                AutoScroll = true,
                Location = new Point(6, 19),
                Size = new Size(422, 75),
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            ClearTemp();

            var serviceName = new[] { "Consultation", "Laboratory", "MedicalImaging", "Prescription", "VariousDocument" };

            foreach (var item in serviceName)
            {
                var rdo = new RadioButton { Text = item, Name = item, Size = new Size(120, 17) };
                rdo.CheckedChanged += CheckRadioButton_Click;
                flpn.Controls.Add(rdo);
            }

            return flpn;
        }

        public BindingSource SearchPatient(string text)
        {
            var bs=new BindingSource();

            var search = _db.Patients.Where(v => v.Id.Contains(text) || v.Name.Contains(text) ||
                                                 v.Phone1.Contains(text) || v.Phone2.Contains(text));
            bs.DataSource = search.Select(v=>new {v.Id,v.Name,v.Gender,v.Phone1,v.Phone2,v.Email,v.Address,v.Height,v.Weight}).ToList();

            return bs;
        }

        public BindingSource SearchDating(string text)
        {
            var bs = new BindingSource();

            var search = _db.Datings.Where(v => v.Id.Contains(text)||v.Patient.Name.Contains(text)||v.PatientId.Contains(text)
                ||v.WorkerId.Contains(text)||v.Worker.Name.Contains(text));
            bs.DataSource = search.ToList();

            return bs;
        }

        public FlowLayoutPanel ShowServiceCategory(string service)
        {
            var flpn=new FlowLayoutPanel();
            flpn.Controls.Clear();
            flpn.AutoScroll = true;
            flpn.Location = new Point(6, 37);
            flpn.Size = new Size(668, 299);
            flpn.Dock=DockStyle.Fill;

            if (service == "Consultation")
            {
                var getCategory = _db.ConsultationCategories.Select(v => v.Name);
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Any(v => v.CategoryId == item);

                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Consultation",
                            BackColor = Color.LimeGreen
                        };

                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Consultation"
                        };

                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "Laboratory")
            {
                var getCategory = _db.LaboratoryCategories.Select(v => v.Name);
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Any(v => v.CategoryId == item);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Laboratory",
                            BackColor = Color.LimeGreen
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Laboratory"
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "MedicalImaging")
            {
                var getCategory = _db.MedicalImagingCategories.Select(v => v.Name);
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Any(v => v.CategoryId == item);

                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "MedicalImaging",
                            BackColor = Color.LimeGreen
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "MedicalImaging"
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "Prescription")
            {
                var getCategory = _db.PrescriptionCategories.Select(v => v.Name);
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Any(v => v.CategoryId == item);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Prescription",
                            BackColor = Color.LimeGreen
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "Prescription"
                        };
                        flpn.Controls.Add(btn);

                        btn.Click += TakeService_Click;
                    }
                    
                }
            }
            if (service == "VariousDocument")
            {
                var getCategory = _db.VariousDocumentCategories.Select(v => v.Name);
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Any(v => v.CategoryId == item);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "VariousDocument",
                            BackColor = Color.LimeGreen                            
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item,
                            Name = "VariousDocument"
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            return flpn;
        }

        public void SubmitService(string patientId,TimeSpan timeSpan)
        {
            var id = AutoIdWaiting();
            var insertWaitingList=new Hospital_Entity_Framework.WaitingList(){Id = id,PatientId = patientId,Time = timeSpan };
            _db.WaitingLists.Add(insertWaitingList);
            _db.SaveChanges();

            var checkTempWait = _db.TempWaits;

            foreach (var item in checkTempWait)
            {
                if (item.ServiceId == "Consultation")
                {
                    var insert = _db.ConsultationCategories.Single(v => v.Name == item.CategoryId);

                    _db.WaitingLists.Single(v=>v.Id==id).ConsultationCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceId == "Laboratory")
                {
                    var insert = _db.LaboratoryCategories.Single(v => v.Name == item.CategoryId);

                    _db.WaitingLists.Single(v => v.Id == id).LaboratoryCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceId == "MedicalImaging")
                {
                    var insert = _db.MedicalImagingCategories.Single(v => v.Name == item.CategoryId);

                    _db.WaitingLists.Single(v => v.Id == id).MedicalImagingCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceId == "Prescription")
                {
                    var insert = _db.PrescriptionCategories.Single(v => v.Name == item.CategoryId);

                    _db.WaitingLists.Single(v => v.Id == id).PrescriptionCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceId == "VariousDocument")
                {
                    var insert = _db.VariousDocumentCategories.Single(v => v.Name == item.CategoryId);

                    _db.WaitingLists.Single(v => v.Id == id).VariousDocumentCategories.Add(insert);
                    _db.SaveChanges();
                }
            }
        }

        private void CheckRadioButton_Click(object sender, EventArgs e)
        {
            var text = (RadioButton)sender;
            var service = text.Name;
            var form = (CheckInForm)Application.OpenForms["CheckInForm"];
            if (form != null)
            {
                var gbo = form.gboCategory;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(service));
            }
        }

        private void TakeService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getServiceName = check.Name;
            var getCategoryName = check.Text;

            var insert=new TempWait(){Id = AutoIdTemp(),ServiceId = getServiceName,CategoryId = getCategoryName};
            _db.TempWaits.Add(insert);
            _db.SaveChanges();

            var form = (CheckInForm)Application.OpenForms["CheckInForm"];
            if (form != null)
            {
                var gbo = form.gboCategory;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(getServiceName));
            }
        }

        private void RemoveService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getServiceName = check.Name;
            var getCategoryName = check.Text;

            var delete = _db.TempWaits.Single(v => v.CategoryId == getCategoryName);
            _db.TempWaits.Remove(delete);
            _db.SaveChanges();

            var form = (CheckInForm)Application.OpenForms["CheckInForm"];
            if (form != null)
            {
                var gbo = form.gboCategory;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(getServiceName));
            }
        }

        private string AutoIdTemp()
        {
            var tempWait = new TempWait();
            try
            {
                var getLastId = _db.TempWaits.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(8));
                num += 1;
                tempWait.Id = string.Concat("TempWait", num);
            }
            catch
            {
                tempWait.Id = "TempWait1";
            }
            return tempWait.Id;
        }

        private string AutoIdWaiting()
        {
            var wait = new Hospital_Entity_Framework.WaitingList();
            try
            {
                var getLastId = _db.WaitingLists.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(4));
                num += 1;
                wait.Id = string.Concat("Wait", num);
            }
            catch
            {
                wait.Id = "Wait1";
            }
            return wait.Id;
        }
       
        public void ClearTemp()
        {
            var clear = _db.TempWaits;

            _db.TempWaits.RemoveRange(clear);
            _db.SaveChanges();
        }

    }
}
