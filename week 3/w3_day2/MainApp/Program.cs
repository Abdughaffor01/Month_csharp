using Domain.Model;
using Infrastructure.Services;


internal class Program
{
   private static int Main(string[] args)
   {
      var empService = new EmployeeService();

      while (true)
      {
         Console.WriteLine();
         Console.WriteLine("Input 1 for get employees");
         Console.WriteLine("Input 2 for add employee");
         Console.WriteLine("Input 3 for update employee");
         Console.WriteLine("Input 4 for delete employee");
         Console.WriteLine("Input 5 for exit program");
         Console.WriteLine("Input Your Number");

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
               Console.WriteLine("Department :" + emp.Faculty.Department);
               Console.WriteLine();
            }
         }
         else if (n == 2)
         {
            Employee em = new Employee();
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
            em.Faculty.Name = Console.ReadLine();
            Console.WriteLine("Department:");
            em.Faculty.Department = Console.ReadLine();
            empService.AddEmployees(em);
         }
         else if (n == 3)
         {
            var em = new Employee();
            Console.WriteLine("Id ticher");
            em.Id = Convert.ToInt32(Console.ReadLine());
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
            em.Faculty.Name = Console.ReadLine();
            Console.WriteLine("Department:");
            em.Faculty.Department = Console.ReadLine();

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
   }
}