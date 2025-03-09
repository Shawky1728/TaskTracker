namespace TaskTracker
{
    internal class Program
    {

        static string[] Tasks = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {

            // welcome user

            //1.add task
            //2.view all tasks
            //3.mark task complete
            //4.remove task
            //5.Exit

            Console.WriteLine("Welcome to my task tracker");
            while (true)
            {   
                
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(
                    "1.Add task \n" +
                    "2.View all tasks  \n" +
                    "3.Mark task complete  \n" +
                    "4.Remove task  \n" +
                    "5.Exit");
                Console.WriteLine("\nEnter Your Choice :");


                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": // Add Task
                        AddTask();
                        break;
                    case "2": // ViewAllTasks
                        ViewAllTasks();
                        break;
                    case "3": //MarkComplete
                        MarkComplete();
                        break;
                    case "4": //Delete
                        DeleteTask();
                        break;
                    case "5": // Exit
                        return;
                    default:
                        Console.WriteLine("Please Enter number from 1 to 5");
                        break;

                }

            }


        }
        private static void AddTask()
        {
            Console.WriteLine("Enter Task Title");
            string title = Console.ReadLine();
            Tasks[TaskIndex] = title;
            TaskIndex++;
            Console.Clear();
            Console.WriteLine("Task Added");
        }

        private static void ViewAllTasks()
        {
            Console.Clear();
            Console.WriteLine("Task List :");
            for (int i = 0; i < TaskIndex; i++)
            {
                Console.WriteLine($"{i + 1} {Tasks[i]}");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter Task Number ");
          
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Clear();
                choice--;
                if (choice >= TaskIndex || choice<0)
                {
                    Console.WriteLine("Task Not found");
                }
                else
                {
                    Tasks[choice] = Tasks[choice]+" Completed";
                    Console.WriteLine("Task Completed");
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
            }


        }

        private static void DeleteTask()
        {
            Console.WriteLine("Enter Task Number");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Clear();
                choice--;
                if (choice >= TaskIndex || choice < 0)
                {
                    Console.WriteLine("Task Not found");
                }
                else
                {
                    for(int i=choice;i<TaskIndex-1; i++)
                    {
                        Tasks[i] = Tasks[i + 1];
                    }
                    TaskIndex--;
                    Console.WriteLine("Task deleted");
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
