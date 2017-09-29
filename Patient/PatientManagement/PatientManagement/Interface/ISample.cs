/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

using System.Collections.Generic;

namespace PatientManagement
{
   public  interface ISample
    {
        string AutoId();
        void Insert(string id, string title,string description);
        void Update(string id, string title,string description);
        void Delete(string id);
        object Show();
        object Show_Sample_Title();
        string  Search_Title(string  title);
        
    }
}
