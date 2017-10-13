using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class WaitingList
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public BindingSource ShowWaiting(string categoryid)
        {
            

            var checkConsultationCategory = _db.WaitingLists.Any(v => v.ConsultationCategories.Any(a => a.Id == categoryid));
            var checkLaboratoryCategory = _db.WaitingLists.Any(v => v.LaboratoryCategories.Any(a => a.Id == categoryid));
            var checkMedicalImagingCategory = _db.WaitingLists.Any(v => v.MedicalImagingCategories.Any(a => a.Id == categoryid));
            var checkPrescriptionCategory = _db.WaitingLists.Any(v => v.PrescriptionCategories.Any(a => a.Id == categoryid));
            var checkVariousDocumentCategory = _db.WaitingLists.Any(v => v.VariousDocumentCategories.Any(a => a.Id == categoryid));

            if (checkConsultationCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.ConsultationCategories.Any(v => v.Id == categoryid)
                    select new
                    {
                        b.Id,
                        b.Patient.Name,
                        b.Time
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkLaboratoryCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.LaboratoryCategories.Any(v => v.Id == categoryid)
                    select new
                    {
                        b.Id,
                        b.Patient.Name,
                        b.Time
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkMedicalImagingCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.ConsultationCategories.Any(v => v.Id == categoryid)
                    select new
                    {
                        b.Id,
                        b.Patient.Name,
                        b.Time
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkPrescriptionCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.PrescriptionCategories.Any(v => v.Id == categoryid)
                    select new
                    {
                        b.Id,
                        b.Patient.Name,
                        b.Time
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkVariousDocumentCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.VariousDocumentCategories.Any(v => v.Id == categoryid)
                    select new
                    {
                        b.Id,
                        b.Patient.Name,
                        b.Time
                    };
                _bs.DataSource = getList.ToList();
            }

            return _bs;
        }

        public Hospital_Entity_Framework.WaitingList GetWaitingListObject(string id)
        {
            var check = _db.WaitingLists.Single(v => v.Id == id);
            return check;
        }
    }
}
