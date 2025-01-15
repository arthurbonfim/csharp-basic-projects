namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segunfo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;

            Console.WriteLine($"\nO resultado da soma é {result}\n");

            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segunfo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;

            Console.WriteLine($"\nO resultado da subração é {result}\n");

            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segunfo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;

            Console.WriteLine($"\nO resultado da divisão é {result}\n");

            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine($"\nO resultado da multiplicação é {result}\n");

            Console.ReadKey();
            Menu();
        }
    }

}