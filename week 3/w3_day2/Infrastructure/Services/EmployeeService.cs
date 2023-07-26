using Domain.Model;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> employees=new List<Employee>();
   public List<Employee> GetEmployees(){
      return employees;
   }
   public void AddEmployees(Employee employee){
      employee.Id=employees.Count()+1;
      employees.Add(employee);
   }
   public int CountEmployees(){
      return employees.Count();
   }
   public string UpdateEmployee(Employee employee)
    {
        var found = employees.Find(emp => emp.Id == employee.Id);
        if (found == null)
        {
            return "Employee not found";
        }
        found.FirstName = employee.FirstName;
        found.LastName = employee.LastName;
        found.Position = employee.Position;
        found.Wholesale = employee.Wholesale;
        found.Salary = employee.Salary;
        found.Faculty = employee.Faculty;
        return "Update successfully";
    }
    public string DeleteEmployee(int id)
    {
        var found = employees.Find(x => x.Id == id);
        if (found == null)
        {
            return "employee not found";
        }
        employees.Remove(found);
        return "Delete successfully";
    }
}
