using Domain.Model;
using Infrastructure.Services;


var empService = new EmployeeService();

while (true)
{
   System.Console.WriteLine();
   System.Console.WriteLine("Input 1 for get employees");
   System.Console.WriteLine("Input 2 for add employee");
   System.Console.WriteLine("Input 3 for update employee");
   System.Console.WriteLine("Input 4 for delete employee");
   System.Console.WriteLine("Input 5 for exit program");
   System.Console.WriteLine("Input Your Number");

   var n = Convert.ToInt32(Console.ReadLine());

   if (n == 1)
   {
      var emps = empService.GetEmployees();
      foreach (var emp in emps)
      {
         Console.WriteLine("employe=" + emp.Id);
         Console.WriteLine("Firstname :" + emp.FirstName);
         Console.WriteLine("Lastname :" + emp.LastName);
         Console.WriteLine("Position :" + emp.Position);
         Console.WriteLine("Wholesale :" + emp.Wholesale);
         Console.WriteLine("Salary :" + emp.Salary);
         Console.WriteLine("Faculty :" + emp.Faculty.Name);
         Console.WriteLine("Dean :" + emp.Faculty.Dean.FirstName);
         Console.WriteLine("Department :" + emp.Faculty.Department.Name);
         System.Console.WriteLine();
      }
   }
   else if (n == 2)
   {
      var em = new Employee();
      Console.WriteLine("Firstname:");
      em.FirstName = Console.ReadLine();
      Console.WriteLine("Lastname:");
      em.LastName = Console.ReadLine();
      Console.WriteLine("Position:");
      em.Position = Console.ReadLine();
      Console.WriteLine("Wholesale:");
      em.Wholesale = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Salary:");
      em.Salary = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Faculty:");
      em.Faculty.Name =Console.ReadLine();
      Console.WriteLine("Dean Faculty:");
      em.Faculty.Dean.FirstName = Console.ReadLine();
      Console.WriteLine("Department:");
      em.Faculty.Department.Name = Console.ReadLine();  
      empService.AddEmployees(em);
   }
   else if (n == 3)
   {
      var em = new Employee();
      System.Console.WriteLine("Id ticher");
      em.Id=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Firstname:");
      em.FirstName = Console.ReadLine();
      Console.WriteLine("Lastname:");
      em.LastName = Console.ReadLine();
      Console.WriteLine("Position:");
      em.Position = Console.ReadLine();
      Console.WriteLine("Wholesale:");
      em.Wholesale = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Salary:");
      em.Salary = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Faculty:");
      em.Faculty.Name =Console.ReadLine();
      Console.WriteLine("Dean Faculty:");
      em.Faculty.Dean.FirstName = Console.ReadLine();
      Console.WriteLine("Department:");
      em.Faculty.Department.Name = Console.ReadLine();

      empService.UpdateEmployee(em);
   }
   else if (n == 4)
   {
      var id = Convert.ToInt32(Console.ReadLine());
      empService.DeleteEmployee(id);
   }
   else if (n == 5)
   {
      return 0;
   }
}