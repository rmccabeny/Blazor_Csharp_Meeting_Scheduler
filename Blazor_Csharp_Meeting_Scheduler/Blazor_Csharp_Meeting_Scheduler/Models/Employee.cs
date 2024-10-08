﻿namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public record Employee
    {
        // establish the properties of the employee class
        public int EmployeeId { get; set; }
        public required string EmployeeName { get; set; }
        public required string DepartmentName { get; set; }
        public required string EmployeeEmail { get; set; }
        public required string EmployeePhone { get; set; }
        public bool IsManager { get; set; }
        public Department? Department { get; set; }

    }
}
