namespace Domain.Model;

public class Employee {
   public int Id { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string Position { get; set; }
   public int  Wholesale { get; set; }
   public decimal Salary { get; set; }
   public Faculty Faculty { get; set; }
}
