namespace Domain.Model;

public class Department
{
   public string Name { get; set; }
   public string Descriptioon { get; set; }
   public Employee Manager{ get; set; }
}
