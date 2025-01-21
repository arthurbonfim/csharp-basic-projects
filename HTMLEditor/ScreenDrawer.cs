namespace HTMLEditor
{
    public class ScreenDrawer
    {
        public static void DrawScreen(int width, int height)
        {
            Console.Write("+");
            DrawHorizontalLine(width);
            Console.WriteLine("+");
            DrawVerticalLine(width, height);
            Console.Write("+");
            DrawHorizontalLine(width);
            Console.WriteLine("+");
        }
        public static void DrawHorizontalLine(int width)
        {
            Console.Write(string.Concat(Enumerable.Repeat("-", width)));
        }
        public static void DrawVerticalLine(int width, int quant)
        {
            for (var lines = 0; lines < quant; lines++)
            {
                Console.Write("|");
                Console.Write(string.Concat(Enumerable.Repeat(" ", width)));
                Console.WriteLine("|");
            }
        }
    }
}