using Domain.Model;
using Infrastructure.Services;

var employeesService = new EmployeeService();
System.Console.WriteLine(employeesService.CountEmployees());

var em1 = new Employee()
{
   Firstname = "Abdughaffor",
   Lastname = "Rahimov",
   DateTime = new DateTime(2001, 02, 20),
   Salary = 500m,
   Department = new Department()
   {
      Name = "It",
      Descriptioon = "Murgh",
      Manager = new Employee()
      {
         Firstname = "Idibek",
         Lastname = "Rahimov",
         DateTime = new DateTime(1990, 02, 01),
         Salary = 1000m,
      }
   }
};
employeesService.AddEmployees(em1);

var em2 = new Employee()
{
   Firstname = "GHaffur",
   Lastname = "Rahimov",
   DateTime = new DateTime(2001, 02, 20),
   Salary = 600m,
   Department = new Department()
   {
      Name = "It",
      Descriptioon = "Murgh",
      Manager = new Employee()
      {
         Firstname = "Idibek",
         Lastname = "Rahimov",
         DateTime = new DateTime(1990, 02, 01),
         Salary = 1000m,
      }
   }
};
employeesService.AddEmployees(em2);
Console.WriteLine(employeesService.CountEmployees());
var em=employeesService.GetEmployees();
foreach (var i in em)
{
   System.Console.WriteLine(i.Firstname);
   System.Console.WriteLine(i.Lastname);
   System.Console.WriteLine(i.DateTime);
   System.Console.WriteLine(i.Salary);

   System.Console.WriteLine("Next employee");
}