using Domain.Model;
namespace Infrastructure.Services;

public class DepartmentService
{
  List<Faculty> departments;
   public DepartmentService()
   {
      departments=new List<Faculty>();
   }
   public List<Faculty> GetEmployees(){
      return departments;
   }
   public void AddEmployees(Faculty department){
      departments.Add(department);
   }
   public int CountEmployees(){
      return departments.Count();
   }
 }
