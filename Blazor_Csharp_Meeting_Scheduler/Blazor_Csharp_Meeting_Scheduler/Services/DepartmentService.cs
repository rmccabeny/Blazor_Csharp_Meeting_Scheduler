using Blazor_Csharp_Meeting_Scheduler.Models;

namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    public class DepartmentService
    {
        // create the list of departments
        private List<Department> departments = new List<Department>();

        // get the list of departments
        public List<Department> GetDepartments()
        {
            return departments;
        }

        // add a department to the list
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        // add an employee to a department
        public void AddEmployeeToDepartment(int id, Employee employee)
        {
            var department = departments.Find(d => d.Id == id);
            department?.Employees.Add(employee);
        }

        // remove an employee from a department
        public void RemoveEmployeeFromDepartment(int id, Employee employee)
        {
            var department = departments.Find(d => d.Id == id);
            department?.Employees.Remove(employee);
        }
    }
}
