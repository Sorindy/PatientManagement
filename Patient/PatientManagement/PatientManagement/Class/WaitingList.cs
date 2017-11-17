using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
   public class WaitingList
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();
        public Hospital_Entity_Framework.Patient Patient;

        public BindingSource ShowWaiting(string  categoryName)
        {
            var checkConsultationCategory = _db.WaitingLists.Any(v => v.ConsultationCategories.Any(a => a.Name == categoryName));
            var checkLaboratoryCategory = _db.WaitingLists.Any(v => v.LaboratoryCategories.Any(a => a.Name == categoryName));
            var checkMedicalImagingCategory = _db.WaitingLists.Any(v => v.MedicalImagingCategories.Any(a => a.Name == categoryName));
            var checkPrescriptionCategory = _db.WaitingLists.Any(v => v.PrescriptionCategories.Any(a => a.Name == categoryName));
            var checkVariousDocumentCategory = _db.WaitingLists.Any(v => v.VariousDocumentCategories.Any(a => a.Name == categoryName));

            if (checkConsultationCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.ConsultationCategories.Any(v => v.Name == categoryName)
                    select new
                    {
                        b.Id,
                        b.PatientId,
                        b.Patient.Name,
                        b.Time,
                        b.Status
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkLaboratoryCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.LaboratoryCategories.Any(v => v.Name == categoryName)
                    select new
                    {
                        b.Id,
                        b.PatientId,
                        b.Patient.Name,
                        b.Time,
                        b.Status
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkMedicalImagingCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.ConsultationCategories.Any(v => v.Name == categoryName)
                    select new
                    {
                        b.Id,
                        b.PatientId,
                        b.Patient.Name,
                        b.Time,
                        b.Status
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkPrescriptionCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.PrescriptionCategories.Any(v => v.Name == categoryName)
                    select new
                    {
                        b.Id,
                        b.PatientId,
                        b.Patient.Name,
                        b.Time,
                        b.Status
                    };
                _bs.DataSource = getList.ToList();
            }
            if (checkVariousDocumentCategory)
            {
                var getList = from b in _db.WaitingLists
                    where b.VariousDocumentCategories.Any(v => v.Name == categoryName)
                    select new
                    {
                        b.Id,
                        b.PatientId,
                        b.Patient.Name,
                        b.Time,
                        b.Status
                    };
                _bs.DataSource = getList.ToList();
            }

            return _bs;
        }

        public Hospital_Entity_Framework.WaitingList GetWaitingListObject(int id)
        {
            var check = _db.WaitingLists.Single(v => v.Id == id);
            return check;
        }
    }
}
