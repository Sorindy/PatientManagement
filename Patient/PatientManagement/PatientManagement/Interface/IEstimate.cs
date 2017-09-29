using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
    public interface IEstimate
    {
        string AutoId();
        void Insert(string id, string categoryid, string workerid, DateTime date, string description);
        void Update(string id, string categoryid, string workerid, DateTime date, string description);
        void Delete(string id);
        object Show();
    }
}
