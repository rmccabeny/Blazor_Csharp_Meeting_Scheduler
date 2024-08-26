using Blazor_Csharp_Meeting_Scheduler.Models;

namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    // create the functionality for the  EmployeeService class
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>()
;       
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await Task.FromResult(new List<Employee>());
        }

        // add an employee to the list
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // remove an employee from the list
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
