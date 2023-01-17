namespace EFCore_CodeFirst.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? Name { get; set; } // nvarchar(50) + not null
        public decimal Budget { get; set; } // money
        public DateTime StartedTime { get; set; } // datetime2(7)

        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
