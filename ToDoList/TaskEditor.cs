namespace ToDoList
{
    public class TaskEditor
    {
        public static List<string> CurrentTasks { get; private set; } = new List<string>();

        public static List<string> CompletedTasks { get; private set; } = new List<string>();
        public static void CreateTask()
        {
            Console.Clear();
            ScreenDrawer.DrawScreen(10);
            ScreenDrawer.DrawHeader("Criação de tarefas");

            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Escreva a tarefa que deseja adicionar:");
            Console.SetCursorPosition(2, 4);

            var task = Console.ReadLine();
            CurrentTasks.Add(task);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Deseja adicionar mais uma tarefa? S = sim | N = não");
            string continueAdding;
            do
            {
                Console.SetCursorPosition(2, 6);
                continueAdding = Console.ReadLine().Trim().ToLower();
                switch (continueAdding)
                {
                    case "s": CreateTask(); break;
                    case "n": Menu.Show(); break;
                    default:
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("Digite uma opção válida. S = sim | N = não");
                        break;
                }

            } while (continueAdding != "s" && continueAdding != "n");

        }
        public static void CompleteTask()
        {
            int screenHeight = 7 + CurrentTasks.Count;

            Console.Clear();
            ScreenDrawer.DrawScreen(screenHeight);
            ScreenDrawer.DrawHeader("Selecione a tarefa que deseja completar");

            ShowTasks(CurrentTasks);
            Console.SetCursorPosition(1, screenHeight - 3);
            ScreenDrawer.DrawLine();

            Console.SetCursorPosition(3, screenHeight - 2);
            Console.Write("Opção: ");
            var input = int.TryParse(Console.ReadLine(), out int slctdTask);
            if (!input || slctdTask > CurrentTasks.Count)
            {
                MessageDisplay.ShowError("Digite uma opção válida", screenHeight);
                CompleteTask();
            }
            else
            {
                CompletedTasks.Add(CurrentTasks[slctdTask - 1]);
                CurrentTasks.RemoveAt(slctdTask - 1);

                if (CurrentTasks.Count <= 0)
                {
                    Thread.Sleep(300);
                    Menu.Show();
                }
                else
                {
                    Console.SetCursorPosition(3, screenHeight - 1);
                    Console.WriteLine("Deseja completar outra tarefa? S = sim | N = não");
                    string? continueOption;
                    do
                    {
                        Console.SetCursorPosition(3, screenHeight);
                        continueOption = Console.ReadLine().Trim().ToLower();
                        if (continueOption != "s" && continueOption != "n")
                            MessageDisplay.ShowError("Digite uma opção válida", screenHeight);
                    } while (continueOption != "s" && continueOption != "n");
                    Thread.Sleep(300);
                    if (continueOption == "s")
                        CompleteTask();
                    else
                        Menu.Show();
                }
            }
        }
        public static void DeleteTask()
        {
            int screenHeight = 7 + CurrentTasks.Count;

            Console.Clear();
            ScreenDrawer.DrawScreen(screenHeight);
            ScreenDrawer.DrawHeader("Selecione a tarefa que deseja Deletar");

            ShowTasks(CurrentTasks);
            Console.SetCursorPosition(1, screenHeight - 3);
            ScreenDrawer.DrawLine(60);

            Console.SetCursorPosition(3, screenHeight - 2);
            Console.Write("Opção: ");
            var input = int.TryParse(Console.ReadLine(), out int slctdTask);
            if (!input || slctdTask > CurrentTasks.Count)
            {
                MessageDisplay.ShowError("Digite uma opção válida", screenHeight);
                DeleteTask();
            }
            else
            {
                CurrentTasks.RemoveAt(slctdTask - 1);

                if (CurrentTasks.Count <= 0)
                {
                    Thread.Sleep(300);
                    Menu.Show();
                }
                else
                {
                    Console.SetCursorPosition(3, screenHeight - 1);
                    Console.WriteLine("Deseja deletar outra tarefa? S = sim | N = não");
                    string? continueOption;
                    do
                    {
                        Console.SetCursorPosition(3, screenHeight);
                        continueOption = Console.ReadLine().Trim().ToLower();
                        if (continueOption != "s" && continueOption != "n")
                        {
                            MessageDisplay.ShowError("Digite uma opção válida", screenHeight);
                        }
                    } while (continueOption != "s" && continueOption != "n");
                    Thread.Sleep(300);
                    if (continueOption == "s")
                        DeleteTask();
                    else
                        Menu.Show();
                }
            }

        }

        public static void ShowTasks(List<string> list, int line = 3)
        {
            Console.SetCursorPosition(23, line);
            Console.WriteLine("Lista de tarefas");
            for (var task = 0; task < list.Count; task++)
            {
                Console.SetCursorPosition(15, ++line);
                Console.WriteLine($"{task + 1}. {list[task]} ");
            }
        }
    }
}