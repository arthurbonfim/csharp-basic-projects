namespace IMCCalculator
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

            Console.WriteLine("===== Calculadora de IMC =====");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Calcular IMC");
            Console.WriteLine("2. Sair\n");

            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: CalculateIMC(); break;
                case 2: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void CalculateIMC()
        {
            Console.Clear();

            Console.WriteLine("Informe seu peso em Kg:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura em metros");
            float height = float.Parse(Console.ReadLine());

            float imc = weight / (height * height);
            Console.WriteLine($"Seu imc é {imc:F2}\n");

            DisplayCategory(imc);
        }
        static void DisplayCategory(float imc)
        {
            if (imc < 16)
                Console.WriteLine("Você está com Magresa Grau III");
            else if (imc < 16.9)
                Console.WriteLine("Você está com Magresa Grau II");
            else if (imc < 18.4)
                Console.WriteLine("Você está com Magresa Grau I");
            else if (imc < 24.9)
                Console.WriteLine("Seu peso está normal");
            else if (imc < 29.9)
                Console.WriteLine("Você está com sobrepeso");
            else if (imc < 34.9)
                Console.WriteLine("Você está com Obesiade Grau I");
            else if (imc < 39.9)
                Console.WriteLine("Você está com Obesidade Grau II");
            else
                Console.WriteLine("Você está com Obesidade Grau III (Mórbida)");

            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
    }
}