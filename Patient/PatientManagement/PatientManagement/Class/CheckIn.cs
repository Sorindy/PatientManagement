﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class CheckIn
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();

        public void InsertWaiting(int patientId, TimeSpan date)
        {
            var insert=new Hospital_Entity_Framework.WaitingList(){PatientId = patientId,Time = date};

            _db.WaitingLists.Add(insert);
            _db.SaveChanges();
        }

        public void DeleteWaiting(int id)
        {
            var delete = _db.WaitingLists.Single(v => v.Id == id);

            _db.WaitingLists.Remove(delete);
            _db.SaveChanges();
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

            var search = _db.Patients.Where(v => v.Name.Contains(text) ||
                                                 v.Phone1.Contains(text) || v.Phone2.Contains(text));
            bs.DataSource = search.Select(v=>new {v.Id,v.Name,v.Gender,v.Phone1,v.Phone2,v.Email,v.Address,v.Height,v.Weight}).ToList();

            return bs;
        }

        public BindingSource SearchDating(string text)
        {
            var bs = new BindingSource();

            var search = _db.Datings.Where(v => v.Patient.Name.Contains(text)||v.Worker.Name.Contains(text));
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
                    var checking = _db.TempWaits.Any(v => v.CategoryName == item);

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
                    var checking = _db.TempWaits.Any(v => v.CategoryName == item);
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
                    var checking = _db.TempWaits.Any(v => v.CategoryName == item);

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
                    var checking = _db.TempWaits.Any(v => v.CategoryName == item);
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
                    var checking = _db.TempWaits.Any(v => v.CategoryName == item);
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

        public void SubmitService(int patientId,TimeSpan timeSpan)
        {
            var getVisit= CheckVisitCount(patientId);
            var insertWaitingList=new Hospital_Entity_Framework.WaitingList(){PatientId = patientId,Time = timeSpan,VisitId = getVisit.Id,VisitCount = getVisit.VisitCount,Visit = getVisit};
            _db.WaitingLists.Add(insertWaitingList);
            _db.SaveChanges();

            var checkTempWait = _db.TempWaits;

            foreach (var item in checkTempWait)
            {
                if (item.ServiceName == "Consultation")
                {
                    var insert = _db.ConsultationCategories.Single(v => v.Name == item.CategoryName);

                    _db.WaitingLists.Single(v=>v.PatientId==patientId).ConsultationCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceName == "Laboratory")
                {
                    var insert = _db.LaboratoryCategories.Single(v => v.Name == item.CategoryName);

                    _db.WaitingLists.Single(v => v.PatientId == patientId).LaboratoryCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceName == "MedicalImaging")
                {
                    var insert = _db.MedicalImagingCategories.Single(v => v.Name == item.CategoryName);

                    _db.WaitingLists.Single(v => v.PatientId == patientId).MedicalImagingCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceName == "Prescription")
                {
                    var insert = _db.PrescriptionCategories.Single(v => v.Name == item.CategoryName);

                    _db.WaitingLists.Single(v => v.PatientId == patientId).PrescriptionCategories.Add(insert);
                    _db.SaveChanges();
                }
                if (item.ServiceName == "VariousDocument")
                {
                    var insert = _db.VariousDocumentCategories.Single(v => v.Name == item.CategoryName);

                    _db.WaitingLists.Single(v => v.PatientId == patientId).VariousDocumentCategories.Add(insert);
                    _db.SaveChanges();
                }
            }
            CheckVisitCount(patientId);
            var getData = _db.WaitingLists.Single(v => v.PatientId == patientId);
            var form = (CheckInForm)Application.OpenForms["CheckInForm"];
            if (form != null) form.WaitingList = getData;
            if (form != null)
            {
                form.Show();
                form.ClearControl();
            }
        }

        private Hospital_Entity_Framework.Visit CheckVisitCount(int patientId)
        {
            try
            {
                var checkVisit = _db.Visits.Where(v => v.PatientId == patientId).OrderByDescending(v=>v.VisitCount).Select(v=>v.VisitCount).First();

                var insert=new Hospital_Entity_Framework.Visit{VisitCount = checkVisit+1,PatientId = patientId,Date = DateTime.Now};
                _db.Visits.Add(insert);
                _db.SaveChanges();

                var getVisit = _db.Visits.Single(v =>v.PatientId==patientId&&v.VisitCount==checkVisit+1);
                return getVisit;
            }
            catch
            {
               var insert=new Hospital_Entity_Framework.Visit{VisitCount = 1,PatientId = patientId,Date = DateTime.Now};
               _db.Visits.Add(insert);
               _db.SaveChanges();

                var getVisit = _db.Visits.Single(v => v.PatientId == patientId && v.VisitCount == 1);
                return getVisit;
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

            var insert=new TempWait(){ServiceName = getServiceName,CategoryName = getCategoryName};
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

            var delete = _db.TempWaits.Single(v => v.CategoryName == getCategoryName);
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

        public void ClearTemp()
        {
            var clear = _db.TempWaits;

            _db.TempWaits.RemoveRange(clear);
            _db.SaveChanges();
        }

    }
}
