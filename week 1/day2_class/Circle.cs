public class Circle{
   const float pi=3.14f;
   public int Radius;
   public string Color;
     public void GetArea()
    {
        System.Console.WriteLine($"GetArea Circle : {pi*Radius*Radius}");
    }
    public void GetCircumference()
    {
         float sum=(Radius*pi)*2f;
        System.Console.WriteLine($"GetCircumference Circle : {sum}");
    }
}