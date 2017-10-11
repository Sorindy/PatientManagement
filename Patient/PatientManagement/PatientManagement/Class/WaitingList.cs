using System;
using System.Collections.Generic;
using System.Linq;
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

        public object Show()
        {
            var getwaiting = from v in _db.WaitingLists 
                select new
                {
                    v.Id,
                    v.PatientId,
                    v.Patient.Name,
                    v.Time,
                };
            _bs.DataSource = getwaiting.ToList();
            return _bs;
        }

    }
}
