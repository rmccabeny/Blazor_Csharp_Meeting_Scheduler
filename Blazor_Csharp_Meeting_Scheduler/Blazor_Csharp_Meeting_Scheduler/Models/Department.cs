namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Department
    {
        // declare the properties of the Department class
        public int Id { get; set; }
        public required string Name { get; set; }
        
        // create list of employees
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
