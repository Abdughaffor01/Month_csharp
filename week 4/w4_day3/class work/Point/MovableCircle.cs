namespace Point;

public class MovableCircle:MovablePoint
{
   int radius;
   MovablePoint center;
   public MovableCircle(int x,int y,int xSpeed,int ySpeed,int radius):base(x,y,xSpeed,ySpeed)=>this.radius=radius;
   
   public override string ToString()=>$"({x},{y}) R({radius})";
   public override void MoveUp() => y += ySpeed;
   public override void MoveDown() => y -= ySpeed;
   public override void MoveLeft() => x -= xSpeed;
   public override void MoveRight() => x += xSpeed;
}