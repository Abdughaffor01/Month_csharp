public class Shape
{
   double x;
   double y;
   public Shape(double x, double y)
   {
      this.x = x;
      this.y = y;
   }
   public string ToString() => $"x = {x} : y = {y}";
   public double Area() => x * y;
   public double Perimeter() => 2 * (x + y);
}