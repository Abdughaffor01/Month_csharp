namespace Domain.Model;

public class Employee {
   public string Firstname { get; set; }
   public string Lastname { get; set; }
   public DateTime DateTime { get; set; }
   public decimal Salary { get; set; }
   public Department? Department { get; set; }
}
