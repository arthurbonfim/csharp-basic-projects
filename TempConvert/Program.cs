namespace TempConvert
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

            Console.WriteLine("===== Conversor de temperatura =====");
            Console.WriteLine("\nEscolha uma opção");
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Celsius para Kelvin");
            Console.WriteLine("3. Fahrenheit para Celsius");
            Console.WriteLine("4. Fahrenheit para Kelvin");
            Console.WriteLine("5. Kelvin para Celsius");
            Console.WriteLine("6. Kelvin para Fahrenheit");
            Console.WriteLine("7. Sair\n");

            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: CToF(); break;
                case 2: CToK(); break;
                case 3: FToC(); break;
                case 4: FToK(); break;
                case 5: KToC(); break;
                case 6: KToF(); break;
                case 7: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        // static void 
        static void CToF()
        {
            Console.Clear();

            Console.WriteLine("Informe a temperatura em Celsius:");
            float c = float.Parse(Console.ReadLine());

            float f = c * 1.8f + 32;
            Console.WriteLine($"{c}C equivalem a {f}F\n");

            Console.ReadKey();
            Menu();
        }
        static void CToK()
        {
            Console.Clear();

            Console.WriteLine("Informe a temperatura em Celsius:");
            float c = float.Parse(Console.ReadLine());

            float k = c + 273;

            Console.WriteLine($"{c}C equivalem a {k}K\n");

            Console.ReadKey();
            Menu();
        }
        static void FToC()
        {
            Console.Clear();

            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            float f = float.Parse(Console.ReadLine());

            float c = (f - 32) * 5 / 9;

            Console.WriteLine($"{f}F equivalem a {c}C\n");

            Console.ReadKey();
            Menu();
        }
        static void FToK()
        {
            Console.Clear();

            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            float f = float.Parse(Console.ReadLine());

            float k = (f - 32) * 5 / 9 + 273.15f;

            Console.WriteLine($"{f}F equivalem a {k}K\n");

            Console.ReadKey();
            Menu();
        }
        static void KToC()
        {
            Console.Clear();

            Console.WriteLine("Informe a teperatura em Kelvin:");
            float k = float.Parse(Console.ReadLine());

            float c = k - 273.15f;

            Console.WriteLine($"{k}K equivalem a {c}C\n");

            Console.ReadKey();
            Menu();
        }
        static void KToF()
        {
            Console.Clear();

            Console.WriteLine("Informe a temperatura em Kelvin:");
            float k = float.Parse(Console.ReadLine());

            float f = (k - 273.15f) * 9 / 5 + 32;

            Console.WriteLine($"{k}K equivalem a {f}F\n");

            Console.ReadKey();
            Menu();
        }
    }
}