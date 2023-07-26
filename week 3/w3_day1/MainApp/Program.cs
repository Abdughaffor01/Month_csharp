using Domain.Model;
using Infrastructure.Services;

var employeesService = new EmployeeService();
for (int i = 1; i < 2; i++)
{
    var emp = new Employee();
    System.Console.WriteLine($"Employee {i}");
    System.Console.Write("Enter your firstname : ");
    emp.Firstname = Console.ReadLine();
    System.Console.Write("Enter your lastname : ");
    emp.Lastname = Console.ReadLine();
    System.Console.Write("Enter your salary : ");
    emp.Salary = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter your birthdate : ");
    emp.DateTime = new DateTime(
    Convert.ToInt32(Console.ReadLine()), // year
    Convert.ToInt32(Console.ReadLine()), // month
    Convert.ToInt32(Console.ReadLine())  // day
    );
    System.Console.WriteLine("Enter name of your department : ");
    emp.Department = new Department(Console.ReadLine());

    employeesService.AddEmployees(emp);
}
Console.WriteLine(employeesService.CountEmployees());
var em = employeesService.GetEmployees();
foreach (var i in em)
{
   Console.WriteLine(i.Firstname);
   Console.WriteLine(i.Lastname);
   Console.WriteLine(i.DateTime.ToShortDateString());
   Console.WriteLine(i.Salary);
   Console.WriteLine();
}