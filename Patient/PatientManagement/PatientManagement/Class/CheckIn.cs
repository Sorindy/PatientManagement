using System;
using System.Collections.Generic;
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
  
        public FlowLayoutPanel ShowService(CheckInsForm checkInsForm)
        {
            var flpn = new FlowLayoutPanel()
            {
                AutoScroll = true,
                Location = new Point(6, 19),
                Size = new Size(422, 75),
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            ClearTemp(checkInsForm.Patient.Id);

            var serviceName = new[] { "Consultation", "Laboratory", "MedicalImaging", "Prescription", "VariousDocument" };

            foreach (var item in serviceName)
            {
                var rdo = new RadioButton { Text = item, Name = item, AutoSize = true,Font = new Font("ROLAND",14),Tag = checkInsForm};
                rdo.CheckedChanged += CheckRadioButton_Click;
                flpn.Controls.Add(rdo);
            }

            return flpn;
        }

        public BindingSource SearchPatient(string text)
        {
            var bs=new BindingSource();

            var search = _db.Patients.Where(v => v.LastName.Contains(text) ||
                                                 v.Phone1.Contains(text) || v.Phone2.Contains(text) || v.FirstName.Contains(text ));
            bs.DataSource = search.Select(v=>new {v.Id,v.FirstName,v.LastName,v.KhmerName,v.Gender,v.Phone1,v.Phone2,v.Email,v.Address,v.Height,v.Weight,v.PatientIdentify}).ToList();

            return bs;
        }

        public BindingSource SearchDating(string text)
        {
            var bs = new BindingSource();

            var search = _db.Datings.Where(v => v.Patient.FirstName.Contains(text)|| v.Patient.LastName.Contains( text ) || v.Worker.FirstName.Contains(text) || v.Worker.LastName.Contains( text ));
            bs.DataSource = search.ToList();

            return bs;
        }

        private FlowLayoutPanel ShowServiceCategory(string service,CheckInsForm checkInsForm)
        {
            var flpn=new FlowLayoutPanel();
            flpn.Controls.Clear();
            flpn.AutoScroll = true;
            flpn.Location = new Point(6, 37);
            flpn.Size = new Size(668, 299);
            flpn.Dock=DockStyle.Fill;
            var id = checkInsForm.Patient.Id;
            if (service == "Consultation")
            {
                var getCategory = _db.ConsultationCategories;
                foreach (var item in getCategory)
                {
                    var checking = _db.TempWaits.Where(v=>v.ServiceName=="Consultation"&&v.PatientId==id).Any(v => v.CategoryId== item.Id);

                    if (checking)
                    {
                        var dic = new Dictionary<string, CheckInsForm> {{service, checkInsForm}};
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November",12),
                            Tag = dic
                        };

                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = dic
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
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "Laboratory" && v.PatientId == id).Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = dic
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = dic
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
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "MedicalImaging" && v.PatientId == id).Any(v => v.CategoryId == item.Id);

                    if (checking)
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = dic
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = dic
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
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "Prescription" && v.PatientId == id).Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = dic
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = dic
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
                    var checking = _db.TempWaits.Where(v => v.ServiceName == "VariousDocument" && v.PatientId == id).Any(v => v.CategoryId == item.Id);
                    if (checking)
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.LimeGreen,
                            Font = new Font("November", 12),
                            Tag = dic
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += RemoveService_Click;
                    }
                    else
                    {
                        var dic = new Dictionary<string, CheckInsForm> { { service, checkInsForm } };
                        var btn = new Button
                        {
                            Location = new Point(3, 3),
                            Size = new Size(160, 81),
                            Text = item.Name,
                            Name = item.Id.ToString(),
                            BackColor = Color.Khaki,
                            Font = new Font("November", 12),
                            Tag = dic
                        };
                        flpn.Controls.Add(btn);
                        btn.Click += TakeService_Click;
                    }
                }
            }
            return flpn;
        }

        private void CheckMedicalRecord(int patientId)
        {
            var chk = _db.MedicalRecords.Any(v => v.PatientId == patientId);
            if (chk == false)
            {
                var insert=new Hospital_Entity_Framework.MedicalRecord(){PatientId = patientId};
                _db.MedicalRecords.Add(insert);
                _db.SaveChanges();
            }
        }

        public void SubmitService(CheckInsForm checkInsForm,TimeSpan timeSpan)
        {
            var checkTemp = _db.TempWaits.Any();
            var patientId = checkInsForm.Patient.Id;
            CheckMedicalRecord(patientId);
            var getVisit = CheckVisitCount(patientId);
            if (checkTemp)
            {
                var getlastWaiting = _db.WaitingLists.OrderByDescending(v => v.Number).FirstOrDefault();
                if (getlastWaiting != null)
                {
                    var insertWaitingList = new Hospital_Entity_Framework.WaitingList() { PatientId = patientId, Time = timeSpan, VisitId = getVisit.Id, VisitCount = getVisit.VisitCount, Visit = getVisit,Number = getlastWaiting.Number+1};
                    _db.WaitingLists.Add(insertWaitingList);
                }
                else
                {
                    var insertWaitingList = new Hospital_Entity_Framework.WaitingList() { PatientId = patientId, Time = timeSpan, VisitId = getVisit.Id, VisitCount = getVisit.VisitCount, Visit = getVisit, Number = 1 };
                    _db.WaitingLists.Add(insertWaitingList);
                }
                _db.SaveChanges();
                var checkTempWait = _db.TempWaits.Where(v=>v.PatientId==patientId).ToList();

                foreach (var item in checkTempWait)
                {
                    if (item.ServiceName == "Consultation")
                    {
                        var insert = _db.ConsultationCategories.First(v => v.Id == item.CategoryId);

                        _db.WaitingLists.First(v => v.PatientId == patientId).ConsultationCategories.Add(insert);
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
                ClearTemp(patientId);
                CheckVisitCount(patientId);
                checkInsForm.Show();
                checkInsForm.ClearControl();
                checkInsForm.WaitingList = _db.WaitingLists.Where(v=>v.VisitId==getVisit.Id).Single(v => v.PatientId == patientId);
            }
            else
            {
                MessageBox.Show(@"Please select any category and service.", @"Error selection");
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
            var form = (CheckInsForm) text.Tag;
            form.pnlSelection.Controls.Clear();
            form.pnlSelection.Controls.Add(ShowServiceCategory(service,form));
        }

        private void TakeService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getName = Convert.ToInt32(check.Name);
            var getText = check.Text;
            var dic =(Dictionary<string,CheckInsForm>) check.Tag;
            foreach (var selectedItem in dic.ToList())
            {
                var service = selectedItem.Key;
                var form = selectedItem.Value;
                if (form != null)
                {
                    var insert = new TempWait() { ServiceName = service, CategoryName = getText, CategoryId = getName, PatientId = form.Patient.Id };
                    _db.TempWaits.Add(insert);
                    _db.SaveChanges();
                    form.pnlSelection.Controls.Clear();
                    form.pnlSelection.Controls.Add(ShowServiceCategory(service, form));
                }
            }
        }

        private void RemoveService_Click(object sender, EventArgs e)
        {
            var check = (Button) sender;
            var getName = Convert.ToInt32(check.Name);
            var dic =(Dictionary<string,CheckInsForm>) check.Tag;
            foreach (var selectedItem in dic.ToList())
            {
                var service = selectedItem.Key;
                var form = selectedItem.Value;
                var delete = _db.TempWaits.Where(v => v.PatientId == form.Patient.Id)
                    .Where(v => v.ServiceName == service).Single(v => v.CategoryId == getName);
                _db.TempWaits.Remove(delete);
                _db.SaveChanges();

                if (form != null)
                {
                    form.pnlSelection.Controls.Clear();
                    form.pnlSelection.Controls.Add(ShowServiceCategory(service, form));
                }
            }
        }

        public void ClearTemp(int patientId)
        {
            var clear = _db.TempWaits.Where(v=>v.PatientId==patientId);

            _db.TempWaits.RemoveRange(clear);
            _db.SaveChanges();
        }

    }
}
