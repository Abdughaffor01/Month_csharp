namespace Circle;

public class RezizableCircle : Circle, Resizable
{
   public RezizableCircle(double radius) : base(radius) { }
   public void Resize(int resize) => base.radius *= resize;
}
