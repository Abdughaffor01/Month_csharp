using Snake;
StaticMethod.MapWidth = 50;
StaticMethod.MapHeight = 20;
Console.SetWindowSize(StaticMethod.MapWidth, StaticMethod.MapHeight);
Console.SetBufferSize(StaticMethod.MapWidth, StaticMethod.MapHeight);
Console.CursorVisible = false;

StaticMethod.DrawBorder();
Console.ReadKey();
