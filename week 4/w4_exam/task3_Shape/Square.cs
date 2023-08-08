namespace task3_Shape;
public class Square : Rectange
{
   double side = 1.0;
   public Square() { }
   public Square(double side) => this.side = side;
   public Square(double side, Enum color, bool filled)
   {
      this.side = side;
      SetColor(color);
      base.filled = filled;
   }
   public double GetSide() => side;
   public double SetSide(double side) => this.side = side;
   public override void SetLength(double length) => base.SetLength(length);
   public override void SetWidth(double width) => base.SetWidth(width);
   public override string ToString() => $"Square [Rectangle [Shape [color={GetColor()},filled={filled}],width={GetWidth()},length={GetLength()}]]";
}