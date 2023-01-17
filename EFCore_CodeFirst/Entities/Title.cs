namespace EFCore_CodeFirst.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public string? Name { get; set; } // nvarchar(50) not null

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
