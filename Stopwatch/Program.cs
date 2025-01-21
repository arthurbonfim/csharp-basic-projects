
namespace Stopwatch
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

            Console.WriteLine("============== Timer ===============");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("\nQuanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = ' ';
            if (data == "0")
            {
                Console.Clear();
                Console.WriteLine("Programa finalizado!");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else
                type = char.Parse(data.Substring(data.Length - 1, 1));

            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);



        }
        static void PreStart(int time)
        {
            Console.Clear();

            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(1500);
            Console.Clear();

            Start(time);
        }
        static void Start(int time)
        {
            Console.Clear();
            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Timer finalizado!");
            Thread.Sleep(1000);
            Menu();
        }
    }
}