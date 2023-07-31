public class Circle : Paint
{
   Paint center;
   const double pi=3.14;
   double radius;

   public Circle(int xcenter, int ycenter, double radius)
   {
      center.SetX(xcenter);
      center.SetY(ycenter);
      this.radius = radius;
   }
   // public Circle(Paint center,double radius){
   //    this.center
   // }
   public double GetRadius() => radius;
   public double SetRadius(double radius) => this.radius = radius;

   public Paint GetCenter() => center;
   public void SetCenter(Paint center) => this.center = center;
   public int GetCenterX() => center.GetX();
   public void SetCenterX(int x) => center.SetX(x);
   public int GetCenterY() => center.GetY();
   public void SetCenterY(int y) => center.SetY(y);
   
   public int[] GetCenterXY() => center.GetXY();
   public void SetCenterXY(int x,int y) {
      center.SetX(x);
      center.SetY(y);
   }
   public override string ToString()
   {
      return $"Circle [center=({center.GetX()},radius={radius}]";
   }
   public double GetArea()
   {
      return pi*radius*radius;
   }
}
