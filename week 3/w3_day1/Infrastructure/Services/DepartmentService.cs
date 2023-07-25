using Domain.Model;
namespace Infrastructure.Services;

public class DepartmentService
{
  List<Department> departments;
   public DepartmentService()
   {
      departments=new List<Department>();
   }
   public List<Department> GetEmployees(){
      return departments;
   }
   public void AddEmployees(Department department){
      departments.Add(department);
   }
   public int CountEmployees(){
      return departments.Count();
   }
 }
