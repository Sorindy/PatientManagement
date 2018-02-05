using System.Collections.Generic;
using Hospital_Entity_Framework;

namespace PatientManagement.Interface
{
    interface ICategory
    {
        void Insert(string name);
        void Update(int id,string name);
        void Delete(int id);
        object Show();
        Dictionary<int,string> ShowCategoryName();
        int SearchId(int categoryId);
        Dictionary<int, string> ShowCategoryForDoctor(int workerId);
        Dictionary<int, string> ShowAllCategoryForHistory();
        WaitingList CheckWaitingList(int patientId,int categoryId);
    }
}
