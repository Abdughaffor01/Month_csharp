namespace Point;

public class MovablePoint : Movable
{
   protected int x;
   protected int y;
   protected int xSpeed;
   protected int ySpeed;
   public MovablePoint() { }
   public MovablePoint(int x, int y, int xSpeed, int ySpeed)
   {
      this.x = x;
      this.xSpeed = xSpeed;
      this.y = y;
      this.ySpeed = ySpeed;
   }
   public override string ToString() => $"({x},{y})";
   public override void MoveUp() => y += ySpeed;
   public override void MoveDown() => y -= ySpeed;
   public override void MoveLeft() => x -= xSpeed;
   public override void MoveRight() => x += xSpeed;
}
