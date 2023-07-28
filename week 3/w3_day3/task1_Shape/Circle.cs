public class Circle:Shape{
   double radius;
   public Circle(double radius)
   {
      this.radius=radius;
   }
   const double pi=3.14;
   public override string ToString() => $"Circle : Pi = {pi} , Radius = {radius}";
   public override double Area() => pi*radius*radius;
   public override double Perimeter() => 2 * pi*radius;
   
}