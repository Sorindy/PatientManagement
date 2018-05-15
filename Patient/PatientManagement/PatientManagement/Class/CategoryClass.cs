namespace PatientManagement.Class
{
    class CategoryClass
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }

        public CategoryClass(int id, int order, string name)
        {
            Id = id;
            Order = order;
            Name = name;
        }
    }
}
