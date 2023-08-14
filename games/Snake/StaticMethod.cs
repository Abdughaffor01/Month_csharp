namespace Snake
{
    public static class StaticMethod
    {
        public static int MapWidth { get; set; }
        public static int MapHeight { get; set; }
        const ConsoleColor BorderColor = ConsoleColor.Green;
        public static void DrawBorder() { 
            for (int i = 0; i < MapWidth; i++) {
                new Pixel(i, 0, BorderColor).Draw();
                new Pixel(i, MapHeight-1, BorderColor).Draw();
            }
            for (int i = 0; i < MapWidth; i++)
            {
                new Pixel(0, i, BorderColor).Draw();
                new Pixel(MapWidth-1, i, BorderColor).Draw();
            }
        }
    }
}
