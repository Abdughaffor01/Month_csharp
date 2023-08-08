namespace task3_Shape;

public class Rectange : Shape
{
   double width = 1.0;
   double length = 1.0;
   public Rectange() { }
   public Rectange(double width, double length)
   {
      this.width = width;
      this.length = length;
   }
   public Rectange(double width, double length, Enum color, bool filled) : base(color, filled)
   {
      this.width = width;
      this.length = length;
   }
   public double GetWidth() => width;
   public virtual void SetWidth(double width) => this.width = width;
   public double GetLength() => length;
   public virtual void SetLength(double length) => this.length = length;
   public override double GetArea() => length * width;
   public override double GetPerimeter() => (length + width) * 2;
   public override string ToString() => $"Rectangle [Shape [color={base.GetColor()} , filled={base.filled}]]";

}
