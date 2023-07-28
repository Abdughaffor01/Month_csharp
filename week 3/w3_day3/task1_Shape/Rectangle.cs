public class Rectangle:Shape{

   double side1;
   double side2;
   public Rectangle(double x,double y){
      side1=x;
      side2=y;
   }
   public override string ToString()=> $"Rectangle :x = {side1} , y = {side2}";

   public override double Area() => side1 * side2;
   public override double Perimeter() => 2 * (side1 + side2);
}