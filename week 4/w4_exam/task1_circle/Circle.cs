namespace task1_circle;

public class Circle
{
   double radius;
   const double pi=3.14;
   public Circle(){}
   public Circle(double radius)=>this.radius=radius;
   public double GetRadius()=>radius;
   public void SetRadius(double radius)=>this.radius=radius;
   public double GetArea()=>pi*radius*radius;
   public double GetCircumference()=>2*pi*radius;
   public override string ToString()=>$"Circle[radius={radius}]";
}
