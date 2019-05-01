using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Employees.Model
{
    public class EmployeeCollection : ObservableCollection<Employee>
    {
        public static EmployeeCollection AllEmployees()
        {
            EmployeeCollection employees = new EmployeeCollection();

            using (var emp = new NorthwindEntities())
            {
                var query = from e in emp.Employees select e;
                var res = query.ToList();
                foreach (var emplo in res)
                {
                    Employee employee = emplo;
                    employees.Add(employee);
                }
            }
            return employees;
        }
    }
}
