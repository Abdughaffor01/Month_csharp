namespace task2_Employee;
public class Employee
{
   int id;
   string firstName;
   string lastName;
   int salary;
   public Employee(int id, string firstName, string lastName, int salary)
   {
      this.id = id;
      this.firstName = firstName;
      this.lastName = lastName;
      this.salary = salary;
   }
   public int GetId() => id;
   public string FirstName() => firstName;
   public string LirstName() => lastName;
   public string GetName() => $"{firstName} {lastName}";
   public int GetSalary() => salary;
   public void SetSalary(int salary) => this.salary = salary;
   public int SetAnualSalary() => salary * 12;
   public int RaiseSalary(int percent) => salary += salary * percent / 100;
   public override string ToString() => $"Employee[id={id} , name={firstName} {lastName} ,salary={salary}]";
}
