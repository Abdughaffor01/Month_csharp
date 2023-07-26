namespace Domain.Model;

public class Faculty
{
   public string Name { get; set; }
   public Department Department { get; set; }
   public Employee Dean { get; set; }
   public Employee DeputyDean { get; set; }
}
