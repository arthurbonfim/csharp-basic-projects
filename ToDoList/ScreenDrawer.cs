namespace ToDoList
{
    public class ScreenDrawer
    {
        public static void DrawScreen(int height, int width = 60)
        {
            DrawHorizontalLine(width);
            DrawVerticalLine(width, height);
            DrawHorizontalLine(width);

        }
        public static void DrawLine(int width = 60)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", width)));
        }
        public static void DrawHeader(string title, float width = 60)
        {
            int left = (int)Math.Floor((width - title.Length) / 2);
            Console.SetCursorPosition(left, 1);
            Console.WriteLine(title);
            Console.SetCursorPosition(1, 2);
            DrawLine();
        }
        static void DrawHorizontalLine(int width)
        {
            Console.Write("+");
            Console.Write(string.Concat(Enumerable.Repeat("-", width)));
            Console.WriteLine("+");
        }
        static void DrawVerticalLine(int width, int quant)
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