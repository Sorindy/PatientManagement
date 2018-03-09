using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
   public class WaitingList
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private  BindingSource _bs ;
        
  
       public Hospital_Entity_Framework.Patient Patient;

        public BindingSource ShowWaitingListByService(string service)
        {
            _bs = new BindingSource();
            if (service == @"Consultation")
            {
             
            }
            if (service == @"Laboratory")
            {

            }
            if (service == @"Prescription")
            {

            }
            if (service == @"MedicalImaging")
            {

            }
            if (service == @"VariousDocument")
            {

            }
            return _bs;
        }

        public BindingSource ShowWaiting(string service,int categoryid)
        {
            _bs = new BindingSource();
            if (service == @"Consultation")
            {
                var checkConsultationCategory = _db.WaitingLists.Any(v => v.ConsultationCategories.Any(a => a.Id  == categoryid));
                if (checkConsultationCategory)
                {
                    var getList = from b in _db.WaitingLists
                        where b.ConsultationCategories.Any(v => v.Id == categoryid)
                        orderby b.Number
                                  select new
                                  {
                                      b.Id,
                                      b.PatientId,
                                      b.Patient.FirstName,
                                      b.Patient.LastName,
                                      Time = b.Time.Hours + " : " + b.Time.Minutes,
                                      b.Status,
                                      b.Number,
                                  };
                    _bs.DataSource = getList.ToList();
                }
            }
            if (service == @"Laboratory")
            {
                var checkLaboratoryCategory = _db.WaitingLists.Any(v => v.LaboratoryCategories.Any(a => a.Id  == categoryid));
                if (checkLaboratoryCategory)
                {
                    var getList = from b in _db.WaitingLists
                        where b.LaboratoryCategories.Any(v => v.Id  == categoryid) orderby b.Number
                        select new
                        {
                            b.Id,
                            b.PatientId,
                            b.Patient.FirstName,
                            b.Patient.LastName,
                            Time = b.Time.Hours + " : " + b.Time.Minutes,
                            b.Status,
                            b.Number
                        };
                    _bs.DataSource = getList.ToList();
                }
            }
            if (service == @"MedicalImaging")
            {
                var checkMedicalImagingCategory = _db.WaitingLists.Any(v => v.MedicalImagingCategories.Any(a => a.Id  == categoryid ));
                if (checkMedicalImagingCategory)
                {
                    var getList = from b in _db.WaitingLists
                                  where b.ConsultationCategories.Any(v => v.Id == categoryid)
                                  orderby b.Number
                        select new
                        {
                            b.Id,
                            b.PatientId,
                            b.Patient.FirstName,
                            b.Patient.LastName,
                            Time = b.Time.Hours + " : " + b.Time.Minutes,
                            b.Status,
                            b.Number
                        };
                    _bs.DataSource = getList.ToList();
                }
            }
            if (service == @"Prescription")
            {
                var checkPrescriptionCategory = _db.WaitingLists.Any(v => v.PrescriptionCategories.Any(a => a.Id  == categoryid ));
                if (checkPrescriptionCategory)
                {
                    var getList = from b in _db.WaitingLists
                                  where b.PrescriptionCategories.Any(v => v.Id == categoryid)
                                  orderby b.Number
                        select new
                        {
                            b.Id,
                            b.PatientId,
                            b.Patient.FirstName,
                            b.Patient.LastName,
                            Time = b.Time.Hours + " : " + b.Time.Minutes,
                            b.Status,
                            b.Number
                        };
                    _bs.DataSource = getList.ToList();
                }
            }
            if (service == @"VariousDocument")
            {
                var checkVariousDocumentCategory = _db.WaitingLists.Any(v => v.VariousDocumentCategories.Any(a => a.Id  == categoryid ));
                if (checkVariousDocumentCategory)
                {
                    var getList = from b in _db.WaitingLists
                                  where b.VariousDocumentCategories.Any(v => v.Id == categoryid)
                                  orderby b.Number
                        select new
                        {
                            b.Id,
                            b.PatientId,
                            b.Patient.FirstName,
                            b.Patient.LastName,
                            Time = b.Time.Hours + " : " + b.Time.Minutes,
                            b.Status,
                            b.Number
                        };
                    _bs.DataSource = getList.ToList();
                }
            }
            return _bs;
        }

        public Hospital_Entity_Framework.WaitingList GetWaitingListObject(int id)
        {
            var waitingList  = _db.WaitingLists.SingleOrDefault(v => v.Id == id);
            return waitingList;
        }

        public BindingSource SeleteAllWaiting()
        {
            _bs = new BindingSource();

            var getList = from b in _db.WaitingLists
                select new
                {
                    b.Id,
                    b.PatientId,
                    b.Patient.FirstName,
                    b.Patient.LastName,
                    Time = b.Time.Hours + " : " + b.Time.Minutes,
                    b.Status,
                    b.Number
                };
            _bs.DataSource = getList.ToList();
            return _bs;
        }

        public void UpdatePatientStatus(int waitingid,bool? status)
        {
            var update = _db.WaitingLists.Single(v => v.Id == waitingid);
            update.Status  = status ;
            _db.WaitingLists .AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void DeleteWaitingList(int waitingid)
        {
            var delete = _db.WaitingLists.Single(v => v.Id == waitingid);
            _db.WaitingLists.Remove(delete);
            _db.SaveChanges();
        }

        public void DeleteConsultationWaitingList(int waitingid,int categoryid)
        {
            var delete = _db.ConsultationCategories.First(v => v.Id == categoryid);
            _db.WaitingLists.First(v => v.Id == waitingid).ConsultationCategories.Remove(delete);
            _db.SaveChanges();
        }

        public bool  CheckWaitingList(int patientid,int waitinglistid)
        {
            var checkConsultationWaitingList = _db.ConsultationCategories.Any(v => v.WaitingLists.Any(a => a.Id == waitinglistid && a.PatientId==patientid));
            var checkLaboratoryWaitingList = _db.LaboratoryCategories.Any(v => v.WaitingLists.Any(a => a.Id == waitinglistid && a.PatientId == patientid));
            var checkPrescriptionWaitingList = _db.PrescriptionCategories.Any(v => v.WaitingLists.Any(a => a.Id == waitinglistid && a.PatientId == patientid));
            var checkMedicalImagingWaitingList = _db.MedicalImagingCategories.Any(v => v.WaitingLists.Any(a => a.Id == waitinglistid && a.PatientId == patientid));
            var checkVariousDocumentWaitingList = _db.VariousDocumentCategories.Any(v => v.WaitingLists.Any(a => a.Id == waitinglistid && a.PatientId == patientid));
            if (checkConsultationWaitingList == false && checkLaboratoryWaitingList == false &&
                checkPrescriptionWaitingList == false && checkMedicalImagingWaitingList == false &&
                checkVariousDocumentWaitingList == false)
            {
                return true;
            }
            return false;
        }

        public void DeleteLaboratoryWaitingList(int waitingid, int categoryid)
        {
            var delete = _db.LaboratoryCategories .First(v => v.Id == categoryid);
            _db.WaitingLists.First(v => v.Id == waitingid).LaboratoryCategories.Remove(delete);
            _db.SaveChanges();
        }

        public void DeletePrescriptionWatingList(int waitingid, int categoryid)
        {
            var delete = _db.PrescriptionCategories.First(v => v.Id == categoryid);
            _db.WaitingLists.First(v => v.Id == waitingid).PrescriptionCategories.Remove(delete);
            _db.SaveChanges();
        }

        public void DeleteMedicalImagingWatingList(int waitingid, int categoryid)
        {
            var delete = _db.MedicalImagingCategories .First(v => v.Id == categoryid);
            _db.WaitingLists.First(v => v.Id == waitingid).MedicalImagingCategories.Remove(delete);
            _db.SaveChanges();
        }

        public void DeleteVariousDocumentWatingList(int waitingid, int categoryid)
        {
            var delete = _db.VariousDocumentCategories .First(v => v.Id == categoryid);
            _db.WaitingLists.First(v => v.Id == waitingid).VariousDocumentCategories .Remove(delete);
            _db.SaveChanges();
        }
    }
}
