using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class CheckIn
    {
        private string _service="";
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
            var flpn = new FlowLayoutPanel()
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
                var rdo = new RadioButton { Text = item, Name = item, AutoSize = true,Font = new Font("ROLAND",14)};
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
            _service = service;
            if (service == "Consultation")
            {
                var getCategory = _db.ConsultationCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v=>v.ServiceName=="Consultation").Any(v => v.CategoryId== item.Id);

                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November",12),
                            Tag = "Consultation"
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
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = "Consultation"
                        };

                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "Laboratory")
            {
                var getCategory = _db.LaboratoryCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "Laboratory").Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag="Laboratory"
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
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = "Laboratory"
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "MedicalImaging")
            {
                var getCategory = _db.MedicalImagingCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "MedicalImaging").Any(v => v.CategoryId == item.Id);

                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = "MedicalImaging"
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
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = "MedicalImaging"
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            if (service == "Prescription")
            {
                var getCategory = _db.PrescriptionCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "Prescription").Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag="Prescription"
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
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = "Prescription"
                        };
                        flpn.Controls.Add(btn);

                        btn.Click += TakeService_Click;
                    }
                    
                }
            }
            if (service == "VariousDocument")
            {
                var getCategory = _db.VariousDocumentCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "VariousDocument").Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = "VariousDocument"
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
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = "VariousDocument"
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
                    var insert = _db.ConsultationCategories.First(v => v.Id == item.CategoryId);

                    _db.WaitingLists.First(v=>v.PatientId==patientId).ConsultationCategories.Add(insert);
                }
                if (item.ServiceName == "Laboratory")
                {
                    var insert = _db.LaboratoryCategories.First(v => v.Id == item.CategoryId);

                    _db.WaitingLists.First(v => v.PatientId == patientId).LaboratoryCategories.Add(insert);
                }
                if (item.ServiceName == "MedicalImaging")
                {
                    var insert = _db.MedicalImagingCategories.First(v => v.Id == item.CategoryId);

                    _db.WaitingLists.First(v => v.PatientId == patientId).MedicalImagingCategories.Add(insert);
                }
                if (item.ServiceName == "Prescription")
                {
                    var insert = _db.PrescriptionCategories.First(v => v.Id == item.CategoryId);

                    _db.WaitingLists.First(v => v.PatientId == patientId).PrescriptionCategories.Add(insert);
                }
                if (item.ServiceName == "VariousDocument")
                {
                    var insert = _db.VariousDocumentCategories.First(v => v.Id == item.CategoryId);

                    _db.WaitingLists.First(v => v.PatientId == patientId).VariousDocumentCategories.Add(insert);
                }
            }
            _db.SaveChanges();
            CheckVisitCount(patientId);
            var form = (CheckInsForm)Application.OpenForms["CheckInsForm"];
            if (form != null)
            {
                form.Show();
                form.ClearControl();
                ClearTemp();
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
            var form = (CheckInsForm)Application.OpenForms["CheckInsForm"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(service));
            }
        }

        private void TakeService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getName = Convert.ToInt32(check.Name);
            var getText = check.Text;

            var insert=new TempWait(){ServiceName = _service,CategoryName = getText,CategoryId = getName};
            _db.TempWaits.Add(insert);
            _db.SaveChanges();

            var form = (CheckInsForm)Application.OpenForms["CheckInsForm"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(_service));
            }
        }

        private void RemoveService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getName = Convert.ToInt32(check.Name);
            var getTag = check.Tag.ToString();

            var delete = _db.TempWaits.Where(v=>v.ServiceName==getTag).Single(v => v.CategoryId == getName);
            _db.TempWaits.Remove(delete);
            _db.SaveChanges();

            var form = (CheckInsForm)Application.OpenForms["CheckInsForm"];
            if (form != null)
            {
                var gbo = form.pnlSelection;
                gbo.Controls.Clear();
                gbo.Controls.Add(ShowServiceCategory(_service));
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
