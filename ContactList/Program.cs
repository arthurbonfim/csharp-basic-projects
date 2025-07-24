// programa simula uma agenda de contatos
// onde um 'nome' vai estar associado a um 'contato' usando dicionários

class Program
{
    static void Main()
    {
        var agenda = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a sua agenda de contatos");
            Console.WriteLine("\n1. Adicionar contato");
            Console.WriteLine("2. Buscar contato");
            Console.WriteLine("3. Listar todos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();
            Console.WriteLine("\n");

            switch (option)
            {
                case "1":
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string phoneNumber = Console.ReadLine();
                    agenda[name] = phoneNumber;
                    Console.WriteLine("Contato Salvo!");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Write("Nome a buscar: ");
                    string search = Console.ReadLine();
                    if (agenda.ContainsKey(search))
                        Console.WriteLine($"{search}: {agenda[search]}");
                    else
                        Console.WriteLine("Contato não encontrado.");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Lista de contatos:\n");
                    foreach (var contact in agenda)
                    {
                        Console.WriteLine($"{contact.Key}: {contact.Value}");
                    }
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Encerrando aplicação...");
                    Thread.Sleep(500);
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
