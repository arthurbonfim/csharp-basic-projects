namespace ToDoList
{
    public class Menu
    {
        public static void Show()
        {
            int screenHeight = 10 + TaskEditor.CurrentTasks.Count;

            Console.Clear();
            ScreenDrawer.DrawScreen(screenHeight);
            ScreenDrawer.DrawHeader("Gerenciador de tarefas");


            TaskEditor.ShowTasks(TaskEditor.CurrentTasks);

            Console.SetCursorPosition(1, screenHeight - 5);
            ScreenDrawer.DrawLine();
            Console.SetCursorPosition(2, screenHeight - 4);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(2, screenHeight - 3);
            Console.Write("1. Criar nova tarefa      | ");
            Console.WriteLine("2. Concluir tarefa");
            Console.SetCursorPosition(2, screenHeight - 2);
            Console.Write("3. Ver tarefas concluidas | ");
            Console.WriteLine("4. Deletar tarefa     ");
            Console.SetCursorPosition(2, screenHeight - 1);
            Console.WriteLine("5. Sair");
            Console.SetCursorPosition(2, screenHeight);

            Console.Write("Opção: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1": TaskEditor.CreateTask(); break;
                case "2":
                    if (TaskEditor.CurrentTasks.Count <= 0)
                    {
                        MessageDisplay.ShowError("Você não possui tarefas em aberto",
                        screenHeight);
                        Show();
                    }
                    else
                        TaskEditor.CompleteTask();
                    break;
                case "3":
                    if (TaskEditor.CompletedTasks.Count <= 0)
                    {
                        MessageDisplay.ShowError("Você não possui tarefas concluídas",
                        screenHeight);
                        Show();
                    }
                    else
                        ShowCompletedTasks();
                    break;
                case "4":
                    if (TaskEditor.CurrentTasks.Count <= 0)
                    {
                        MessageDisplay.ShowError("Você não possui tarefas em aberto",
                        screenHeight);
                        Show();
                    }
                    else
                        TaskEditor.DeleteTask();
                    break;
                case "5":
                    MessageDisplay.EndAplicationMessage(screenHeight);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Environment.Exit(0);
                    break;
                default:
                    MessageDisplay.ShowError("Digite uma opção válida", screenHeight);
                    Show();
                    break;
            }
        }
        public static void ShowCompletedTasks()
        {
            int screenHeight = 5 + TaskEditor.CompletedTasks.Count;

            Console.Clear();
            ScreenDrawer.DrawScreen(screenHeight);
            ScreenDrawer.DrawHeader("Tarefas completas");
            TaskEditor.ShowTasks(TaskEditor.CompletedTasks);
            Console.SetCursorPosition(1, screenHeight - 1);
            ScreenDrawer.DrawLine(60);
            Console.SetCursorPosition(44, screenHeight);
            Console.Write("[ENTER] - Voltar");
            Console.ReadKey();
            Show();
        }
    }
}