﻿namespace EFCore_CodeFirst.Entities
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; } // money
        public DateTime StartedTime { get; set; } // datetime2(7)

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
