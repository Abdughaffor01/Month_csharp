namespace task1_Point2d;

public class Point2D
{
   public int x { get; set; }
   public int y { get; set; }
   public Point2D()
   {

   }
   public Point2D(int x, int y)
   {
      this.x = x;
      this.y = y;
   }
   public override string ToString() => $"({x},{y})";
}
