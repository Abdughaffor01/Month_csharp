namespace task3_Shape;

public class Circle : Shape
{
   const double pi = 3.14;
   double radius;
   public Circle() { }
   public Circle(double radius) => this.radius = radius;
   public Circle(double radius, Enum color, bool filled) : base(color, filled) => this.radius = radius;
   public double GetRadius() => radius;
   public override double GetArea() => pi * radius * radius;
   public override double GetPerimeter() => 2 * pi * radius;
   public override string ToString() => $"Circle [Shape [color={base.GetColor()} , filled={base.filled}] ,radius={radius}]";

}
