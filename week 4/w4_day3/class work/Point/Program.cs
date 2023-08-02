using Point;

MovableCircle mcircle=new MovableCircle(2,3,1,1,20);
Console.WriteLine(mcircle.ToString());
mcircle.MoveUp();
mcircle.MoveLeft();
mcircle.MoveDown();
Console.WriteLine(mcircle.ToString());
mcircle.MoveRight();
mcircle.MoveRight();
Console.WriteLine(mcircle.ToString());
