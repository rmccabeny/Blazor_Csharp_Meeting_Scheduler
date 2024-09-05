namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Employee
    {
        // establish the properties of the employee class
        public int EmployeeId { get; set; }
        public required string EmployeeName { get; set; }
        public required string DepartmentName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public bool IsManager { get; set; }

    }
}
