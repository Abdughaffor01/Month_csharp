namespace task1_Point2d;

public class Point3D:Point2D
{
   public int z { get; set; }
   public Point3D()
   {
      
   }
   public Point3D(int x,int y,int z):base(x,y)
   {
      this.z=z;
   }
   public override string ToString()=> $"({x},{y},{z})";
}
