namespace PatientManagement.Interface
{
    interface ICategory
    {
        string AutoId();
        void Insert(string id, string name);
        void Update(string id, string name);
        void Delete(string id);
        object Show();
    }
}
