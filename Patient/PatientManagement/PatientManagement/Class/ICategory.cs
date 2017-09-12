/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement
{
   public  interface ICategory
   {
       string AutoId();
       void Insert(string id, string name);
       void Update(string id, string name);
       void Delete(string id);
       object Show();
   }
}
