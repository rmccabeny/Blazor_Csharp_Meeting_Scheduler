namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public record Department
    {
        // declare the properties of the Department class
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        
        // create list of employees
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
