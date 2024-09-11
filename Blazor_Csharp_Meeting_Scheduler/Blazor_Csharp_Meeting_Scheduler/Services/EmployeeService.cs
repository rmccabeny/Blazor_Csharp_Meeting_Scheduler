using Blazor_Csharp_Meeting_Scheduler.Models;
using System.Threading.Tasks;
namespace Blazor_Csharp_Meeting_Scheduler.Services;

// create the functionality for the  EmployeeService class
public class EmployeeService
{
    private readonly List<Employee> employees = new List<Employee>(); 
    
   
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await Task.FromResult(new List<Employee>());
    }

    // add an employee to the list
    public Task<List<Employee>> AddEmployee(Employee employee)
    {
        employees.Add(employee);
        return Task.FromResult(employees);
    }

    // remove an employee from the list
    public Task<List<Employee>> RemoveEmployee(Employee employee)
    {
        employees.Remove(employee);
        return Task.FromResult(employees);
    }
}
