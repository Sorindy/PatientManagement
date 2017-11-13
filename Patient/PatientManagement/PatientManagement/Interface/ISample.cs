
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
    }
}
