
namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            ScreenDrawer.DrawScreen(30, 12);
            WriteOptions();
            var opt = short.Parse(Console.ReadLine());
            HandleMenuOption(opt);
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1, 2);
            ScreenDrawer.DrawHorizontalLine(30);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1. Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2. Abrir");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("3. Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(); break;
                case 3:
                    Console.SetCursorPosition(3, 11);
                    Console.Write("Encerrando aplicação");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Write(".");
                    Thread.Sleep(300);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Environment.Exit(0);
                    break;
                default:
                    Console.SetCursorPosition(3, 11);
                    Console.WriteLine("Insira uma opção válida.");
                    Thread.Sleep(800);
                    Show();
                    break;
            }
        }
    }
}