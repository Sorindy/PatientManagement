namespace PatientManagement.Interface
{
    interface ICategory
    {
        void Insert(string name);
        void Update(int id,string name);
        void Delete(int id);
        object Show();
    }
}
