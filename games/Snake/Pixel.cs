public class Pixel
{
    public ConsoleColor Color { get; }
    public int X { get; }
    public int Y { get; }
    public Pixel(int x, int y, ConsoleColor color)
    {
        X = x;
        Y = y;
        Color = color;
    }
    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("#");
    }
    public void Clear()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(" ");
    }
}