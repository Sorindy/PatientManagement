using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class Visit
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public object ShowConsultationVisitEstimate(int patientid)
        {
            var getestimate =
            _db.ConsultationEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getestimate.Select(n=>new{n.Id,n.ConsultationCategory.Name,n.Date,n.Description}).ToList();
            return _bs ;
        }
        public object ShowLaboratoryVisitEstimate(int patientid)
        {
            var getestimate =
                _db.LaboratoryEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getestimate.Select(n => new { n.Id, n.LaboratoryCategory.Name, n.Date, n.Description }).ToList();
            return _bs;
        }
        public object ShowMedicalImagingVisitEstimate(int patientid)
        {
            var getestimate =
                _db.MedicalImagingEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getestimate.Select(n => new { n.Id, n.MedicalImagingCategory.Name, n.Date, n.Description }).ToList();
            return _bs;
        }
        public object ShowPrescriptionVisitEstimate(int patientid)
        {
            var getestimate =
                _db.PrescriptionEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getestimate.Select(n => new { n.Id, n.PrescriptionCategory.Name, n.Date, n.Description }).ToList();
            return _bs;
        }
        public object ShowVariousDocumentVisitEstimate(int patientid)
        {
            var getestimate =
                _db.VariousDocumentEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getestimate.Select(n => new { n.Id, n.VariousDocumentCategory.Name, n.Date, n.Description }).ToList();
            return _bs;
        }

    }
}
