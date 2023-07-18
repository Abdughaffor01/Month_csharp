public class Shape
{
   public string Color;
   public string Name;
   public int PositionX;
   public int PositionY;
   public void GetPosition()
   {
      System.Console.WriteLine($"Get PositionX   : {PositionX}");
      System.Console.WriteLine($"Get PositionY   : {PositionY}");
   }
   public void GetFullInfo()
   {
      System.Console.WriteLine($"Color Shape     : {Color}");
      System.Console.WriteLine($"Name Shape      : {Name}");
      System.Console.WriteLine($"PositionX Shape : {PositionX}");
      System.Console.WriteLine($"PositionY Shape : {PositionY}");
   }
}