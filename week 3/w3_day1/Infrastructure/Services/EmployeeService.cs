using Domain.Model;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> employees;
   public EmployeeService()
   {
      employees=new List<Employee>();
   }
   public List<Employee> GetEmployees(){
      return employees;
   }
   public void AddEmployees(Employee employee){
      employees.Add(employee);
   }
   public int CountEmployees(){
      return employees.Count();
   }
}
