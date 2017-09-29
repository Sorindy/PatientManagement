using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Interface
{
    interface ICategoryStatus
    {
        string AutoId();
        void Insert(string id, string catid, bool status);
        void Delete(string id);
        void Update(string id, string catid, bool status);
    }
}
