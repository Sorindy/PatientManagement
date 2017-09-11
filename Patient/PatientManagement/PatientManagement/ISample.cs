/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement
{
   public  interface ISample
    {
        string AutoId();
        void Insert(string id, string title,string description);
        void Update(string id, string title,string description);
        void Delete(string id);
        object Show();
    }
}
