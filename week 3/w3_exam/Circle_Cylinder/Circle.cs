public class Circle
{
   protected const double pi=3.14;
   double radius;
   string color;
   public Circle() { }
   public Circle(double radius)
   {
      this.radius = radius;
   }
   public Circle(double radius, string color)
   {
      this.radius = radius;
      this.color = color;
   }
   public double GetRadius() => radius;
   public void SetRadius(double radius) => this.radius = radius;
   public string GetColor() => color;
   public void SetColor(string color) => this.color = color;
   public override string ToString() => $"Radius = {radius} , color = {color}";
   public double GetArea()=> pi*radius*radius;  

}