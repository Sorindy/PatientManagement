using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class WaitingList
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.WaitingList _waitingList = new Hospital_Entity_Framework.WaitingList();
        private BindingSource _bs = new BindingSource();

        public object ShowWaiting(string categoryid)
        {
            if (categoryid.StartsWith("C"))
            {
                //var getwaiting = _db.WaitingLists.Select(v => v.ConsultationCategories.Select(item => item.Id == categoryid));
                var getwaiting = from v in _db.WaitingLists
                    where v.ConsultationCategories.Single( ).Id  == categoryid
                    select new
                    {
                        v.Id,
                        v.PatientId,
                        v.Patient.Name,
                        v.Time,
                    };
                _bs.DataSource = getwaiting.ToList();
            }
            if (categoryid.StartsWith("P"))
            {
                var getwaiting = _db.WaitingLists.Select(v => v.PrescriptionCategories.Select(item => item.Id == categoryid));
                _bs.DataSource = getwaiting.ToList();
            }
            if (categoryid.StartsWith("L"))
            {
                var getwaiting = _db.WaitingLists.Select(v => v.LaboratoryCategories.Select(item => item.Id == categoryid));
                _bs.DataSource = getwaiting.ToList();
            }
            if (categoryid.StartsWith("M"))
            {
                var getwaiting = _db.WaitingLists.Select(v => v.MedicalImagingCategories.Select(item => item.Id == categoryid));
                _bs.DataSource = getwaiting.ToList();
            }
            if (categoryid.StartsWith("v"))
            {
                var getwaiting = _db.WaitingLists.Select(v => v.VariousDocumentCategories.Select(item => item.Id == categoryid));
                _bs.DataSource = getwaiting.ToList();
            }
            return _bs;
        }

        

    }
}
