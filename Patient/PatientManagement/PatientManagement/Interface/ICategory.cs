namespace PatientManagement.Interface
{
    interface ICategory
    {
        void Insert(string name);
        void Update(string name);
        void Delete(int id);
        object Show();
    }
}
