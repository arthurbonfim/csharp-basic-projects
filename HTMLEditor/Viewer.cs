using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public class Viewer
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para abrir o arquivo:");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                text = Replace(text);
                Console.WriteLine("--------------------");
                Console.WriteLine(text);
            }
            Console.ReadKey();
            Menu.Show();
        }

        public static string Replace(string text)
        {
            // Regex para encontrar conteúdo entre as tags <strong>
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);

            // Substituir conteúdo com a tag removida e aplicando uma cor
            return strong.Replace(text, match =>
            {
                string content = match.Groups[1].Value; // Captura o conteúdo entre as tags
                return $"\u001b[34m{content}\u001b[0m"; // Adiciona cor azul no terminal ANSI
            });
        }
    }
}