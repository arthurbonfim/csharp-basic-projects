namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("===== Editor de textos =====");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Abrir arquivo");
            Console.WriteLine("2. Criar novo arquivo");
            Console.WriteLine("3. Sair");
            Console.WriteLine("-----------------------------");

            short opt = short.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: OpenFile(); break;
                case 2: CreateFile(); break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Aplicação encerrada!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Selecione uma opção válida.");
                    Thread.Sleep(1000);
                    Menu();
                    break;
            }
        }
        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para o arquivo");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine("--------------------");
                Console.WriteLine(text);
            }
            Console.ReadKey();
            Menu();

        }
        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto");
            Console.WriteLine("------------------");

            string text = "";
            ConsoleKey key;

            do
            {
                string input = Console.ReadLine();
                text += input + "\n";
                Console.WriteLine("Pressine ESC para sair out Enter para continuar escrevendo");
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Escape);

            SaveFile(text);
        }
        static void SaveFile(string text)
        {
            Console.Clear();

            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine("Arquivo salvo com sucesso!");
            Console.ReadKey();
            Menu();
        }
    }
}