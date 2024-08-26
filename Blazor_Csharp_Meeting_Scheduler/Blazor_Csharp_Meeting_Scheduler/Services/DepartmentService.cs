using Blazor_Csharp_Meeting_Scheduler.Models;

namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    public class DepartmentService
    {
        // create the list of departments
        private readonly List<Department> departments = new List<Department>
        {
            new Department { Name = "IT" },
            new Department { Name = "Sales" },
            new Department { Name = "Human Resources" },
            new Department { Name = "Management" },
            new Department { Name = "Warehouse" }

        };

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
            if (department != null)
            {
                department.Employees.Add(employee);
            }
        }

        // remove an employee from a department
        public void RemoveEmployeeFromDepartment(int id, Employee employee)
        {
            var department = departments.Find(d => d.Id == id);
            if (department != null)
            {
                department.Employees.Remove(employee);
            }
            
        }
    }
}
