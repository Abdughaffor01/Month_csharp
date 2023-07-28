public class Shape:Location
{
   public Location c = new Location();

   public override string ToString() => $"x = {c.x} : y = {c.y}";
   public virtual double Area() => c.x * c.y;
   public virtual double Perimeter() => 2 * (c.x + c.y);
}