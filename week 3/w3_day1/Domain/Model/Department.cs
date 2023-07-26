namespace Domain.Model;

public class Department
{
   public Department(string name) => Name=name;
   public string Name { get; set; }
   public string Descriptioon { get; set; }
   public Employee Manager{ get; set; }
}
