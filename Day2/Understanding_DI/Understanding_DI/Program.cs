namespace Understanding_DI
{
    class Identity
    {
        public int EmpId { get; set; }
        public string BloodGroup { get; set; }
    }

    class Employee
    {
        public Employee()
        {
            this.Id = new Identity() { EmpId = 101, BloodGroup = "O+" };
        }
        public Identity Id { get; set; }
        public string Name { get; set; }
    }

    //class Project
    //{
    //    public Project()
    //    {
    //        Manager = new Employee() { Id = 1, Name = "ABC" };
    //    }
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Employee Manager { get; set; }
    //}

    class Project
    {
        //public Project(Employee emp)
        //{
        //    Manager = emp;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee Manager { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var abcEmp = new Employee() { Name = "ABC" };
            //var project = new Project(abcEmp);
            var project = new Project();
            project.Manager = abcEmp;
            Console.WriteLine(project.Manager.Id.EmpId);
            project = null;
            Console.WriteLine(abcEmp.Id.EmpId);
            abcEmp = null;
            Console.WriteLine(abcEmp.Id.EmpId);
        }
    }
}