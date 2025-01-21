using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.ForegroundColor = ConsoleColor.Black;
            ScreenDrawer.DrawScreen(30, 3);
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Modo Editor");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Presione ESC para Sair");
            Console.WriteLine();

            Start();
        }
        public static void Start()
        {
            var text = new StringBuilder();
            ConsoleKey key;

            do
            {
                var line = Console.ReadLine();
                text.Append(line + "\n");
                //read the key
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                //if the key isn't ESC print it
                if (key != ConsoleKey.Escape)
                {
                    text.Append(keyInfo.KeyChar);
                    Console.Write(keyInfo.KeyChar);
                }
            } while (key != ConsoleKey.Escape);

            ScreenDrawer.DrawHorizontalLine(44);
            Console.WriteLine();

            string opt;
            Console.WriteLine("Deseja Salvar o arquivo? (S = sim | N = não)");
            do
            {
                opt = Console.ReadLine().Trim().ToLower();
                if (opt != "s" && opt != "n")
                {
                    Console.WriteLine("Digite uma opção válida. (S = sim | N = não)");
                    Thread.Sleep(1000);
                }
            } while (opt != "s" && opt != "n");

            if (opt == "n")
                Menu.Show();
            else
                SaveFile(string.Concat(text));

        }
        public static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para salvar o arquivo.");
            var path = Console.ReadLine();
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine("Arquivo Salvo com sucesso");
            Console.ReadKey();
            Menu.Show();
        }
    }
}