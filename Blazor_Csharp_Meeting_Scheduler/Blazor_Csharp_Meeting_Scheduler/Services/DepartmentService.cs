using Blazor_Csharp_Meeting_Scheduler.Models;

namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    public class DepartmentService
    {
        // create the list of departments
        private readonly List<Department> departments = new List<Department>
        {
            new Department { DepartmentName = "IT" },
            new Department { DepartmentName = "Sales" },
            new Department { DepartmentName = "Human Resources" },
            new Department { DepartmentName = "Management" },
            new Department { DepartmentName = "Warehouse" }

        };

        // get the list of departments
        public  Task <List<Department>> GetDepartmentsAsync()
        {
            return Task.FromResult(departments);
        }

        // add a department to the list
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        // add an employee to a department
        public void AddEmployeeToDepartment(int id, Employee employee)
        {
            var department = departments.Find(d => d.DepartmentId == id);
            if (department != null)
            {
                department.Employees.Add(employee);
            }
        }

        // remove an employee from a department
        public void RemoveEmployeeFromDepartment(int id, Employee employee)
        {
            var department = departments.Find(d => d.DepartmentId == id);
            if (department != null)
            {
                department.Employees.Remove(employee);
            }
            
        }
    }
}
