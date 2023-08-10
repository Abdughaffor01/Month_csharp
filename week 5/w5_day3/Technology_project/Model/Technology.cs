using Technology.Enum;
namespace Technology.Model;
public abstract class Technology
{
   public int ID { get; set; }
   public TypeTechnology TypeTechnologyy { get; set; }
   public string Name { get; set; }
   public int  CPU { get; set; }
   public int  OZU { get; set; }
   public string  GPU { get; set; }
   public int  Storage { get; set; }
   public TypeDispley Displey { get; set; }
}
