namespace EFCore_CodeFirst.Entities
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string? Title { get; set; } // nvarchar(100) + not null
        public string? Location { get; set; } // nvarchar(100) + not null

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
