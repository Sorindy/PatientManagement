using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class Visit
    {
        private HospitalDbContext _db = new HospitalDbContext();
       // private Hospital_Entity_Framework.Visit _visit = new Hospital_Entity_Framework.Visit();
        private BindingSource _bs = new BindingSource();

        //public object ShowVisit(string patientid )
        //{
        //    var checkconsultaionvisit = _db.Visits.Any(v => v.ConsultationEstimates.Any(s => s.Visits.Any(t => t.PatientId == patientid)));
        //    var checkprescriptionvisit = _db.Visits.Any(v => v.PrescriptionEstimates.Any(s => s.Visits.Any(t => t.PatientId == patientid)));
        //    var checklaboratoryvisit = _db.Visits.Any(v => v.LaboratoryEstimates.Any(s => s.Visits.Any(t => t.PatientId == patientid)));
        //    var checkmedicalimagingvisit = _db.Visits.Any(v => v.MedicalImagingEstimates.Any(s => s.Visits.Any(t => t.PatientId == patientid)));
        //    var checkvarioudocumentvisit = _db.Visits.Any(v => v.VariousDocumentEstimates.Any(s => s.Visits.Any(t => t.PatientId == patientid)));

        //    if (checkconsultaionvisit)
        //    {
        //        var getlist = from v in _db.ConsultationEstimates 
        //                      where v.Visits.Any( s=>s.PatientId==patientid) 
        //                      select new
        //                      {
        //                          v.Id,
        //                          v.PatientId,
        //                          v.Date,
        //                      };
        //        _bs.DataSource = getlist.ToList();
        //    }
        //    if (checkprescriptionvisit)
        //    {
        //        var getlist = from v in _db.Visits
        //                      where v.PrescriptionEstimates.Any(a => a.Id == estimateid)
        //                      select new
        //                      {
        //                          v.Id,
        //                          v.PatientId,
        //                          v.Date,
        //                      };
        //        _bs.DataSource = getlist.ToList();
        //    }
        //    if (checklaboratoryvisit)
        //    {
        //        var getlist = from v in _db.Visits
        //                      where v.LaboratoryEstimates.Any(a => a.Id == estimateid)
        //                      select new
        //                      {
        //                          v.Id,
        //                          v.PatientId,
        //                          v.Date,
        //                      };
        //        _bs.DataSource = getlist.ToList();
        //    }
        //    if (checkmedicalimagingvisit)
        //    {
        //        var getlist = from v in _db.Visits
        //                      where v.MedicalImagingEstimates.Any(a => a.Id == estimateid)
        //                      select new
        //                      {
        //                          v.Id,
        //                          v.PatientId,
        //                          v.Date,
        //                      };
        //        _bs.DataSource = getlist.ToList();
        //    }
        //    if (checkvarioudocumentvisit)
        //    {
        //        var getlist = from v in _db.Visits
        //                      where v.VariousDocumentEstimates.Any(a => a.Id == estimateid)
        //                      select new
        //                      {
        //                          v.Id,
        //                          v.PatientId,
        //                          v.Date,
        //                      };
        //        _bs.DataSource = getlist.ToList();
        //    }
        //    return _bs;
        //}

        public object ShowVisitEstimate(string patientid)
        {
            var getconsultationestimate =
       _db.ConsultationEstimates.Where(v => v.Visits.Any(s => s.PatientId == patientid));
            _bs.DataSource = getconsultationestimate.ToList();
            return _bs ;
        }

    }
}
