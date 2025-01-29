namespace ToDoList
{
    class MessageDisplay
    {
        public static void ShowError(string message, int screenHeight, int screenWidth = 60)
        {
            var left = screenWidth - message.Length;
            Console.SetCursorPosition(left, screenHeight);
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.SetCursorPosition(left, screenHeight);
            Console.WriteLine(string.Concat(Enumerable.Repeat(" ", message.Length)));
        }
        public static void EndAplicationMessage(int screenHeight)
        {
            Console.SetCursorPosition(37, screenHeight);
            Console.Write("Encerrando aplicação");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}