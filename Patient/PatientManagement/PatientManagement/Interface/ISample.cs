
using System.Collections.Generic;
using System.Windows.Forms;

namespace PatientManagement.Interface
{
   public  interface ISample
    {
        void Insert(string title,string description,int categoryid);
        void Update(int id,string title,string description,int categoryid);
        void Delete(int id);
        object Show();
        object Show_Sample_Title();
        string Search_Title(string  title);
        Dictionary<int, string> ShowDictionary(int categoryId);
        string Path(int value);
        Dictionary<int, string> SearchTitle(int category,string title);
        TreeNode AddNodeToService();
        Dictionary<Dictionary<Dictionary<string, int>, int>, string> SearchTitle(string title);
    }
}
