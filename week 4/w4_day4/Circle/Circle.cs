namespace Circle;

public class Circle :GeometricObject
{
   const double pi = 3.14;
   protected double radius;
   public Circle(double radius) => this.radius = radius;
   public double GetPerimeter() => pi * radius * 2;
   public double GetArea() => pi * radius * radius;
}
