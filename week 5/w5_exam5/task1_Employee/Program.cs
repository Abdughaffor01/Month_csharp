using task1_Employee;

Employee employee = new Employee(1,"Ghaffor","Rahimov",2500);

Employee employee1 = new Employee(2, "Idibek", "Rahimov", 2500);

Console.WriteLine(employee.GetSalary());
employee.SetSalary(5000);
Console.WriteLine(employee.GetSalary());
Console.WriteLine(employee1.GetName());
