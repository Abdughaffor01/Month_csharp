public class Cylinder : Circle
{
   double height;
   public Cylinder() { }
   public Cylinder(double height) => this.height = height;
   public Cylinder(double height, double radius)
   {
      this.height = height;
      SetRadius(radius);
   }
   public Cylinder(double height, double radius, string color)
   {
      this.height = height;
      SetRadius(radius);
      SetColor(color);
   }
   public double GetHeight() => height;
   public void SetHeight(double height) => this.height = height;
   public double GetVolume() => pi * (GetRadius() * GetRadius()) * height;
   public override string ToString() => $"Radius = {GetRadius()} , color = {GetColor()}, height = {height}";
}