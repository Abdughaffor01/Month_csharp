namespace Technology;

public class Computer
{
   public int Ram { get; set; }
   public int Storage { get; set; }
   public string Keyboard { get; set; }
   public void AddRam(int ram)
   {
      Ram += ram;
   }
   public void AddStorage(int ram)
   {
      Storage += ram;
   }
}
