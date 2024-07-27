namespace ToDo_List
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;

        // ToDo_List
        //Welcome user 
        //add task 
        //view tasks 
        //mark the task 
        //Remove task 
        //Exit 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello in my ToDo list :)");
           

            while (true)
            {
                Console.WriteLine("__________________________________________");
                Console.Write("[1]Add task \n[2]View All Tasks \n[3]Mark task \n[4]Remove task\n[5]Exit \nEnter the number : ");
                var userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("=======");
                        AddTask();
                        break;
                    case "2":
                        Console.WriteLine("=======");
                        ViewTask();
                        break;
                    case "3":
                        Console.WriteLine("=======");
                        MarkTask();
                        break;
                    case "4":
                        Console.WriteLine("=======");
                        RemoveTask();
                        break;
                    case "5":
                        Console.WriteLine("Exit!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid number");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Please enter task you want to add :");
            string taskTitle = Console.ReadLine();
            tasks[taskIndex] = taskTitle;
            Console.WriteLine("Task Added. ");
            taskIndex++;
            


        }
        private static void ViewTask()
        {
            Console.WriteLine("Tasks list :");
           for (int i = 0;i<taskIndex;i++)
            {
                Console.WriteLine($"{i + 1}- {tasks[i]}");
            }

        }
        private static void MarkTask()
        {
            Console.Write("Please enter number :");
            int  userInput = int.Parse(Console.ReadLine()); 

            tasks[userInput-1] = tasks[userInput -1] + "--COMPLETED ";


        }

        private static void RemoveTask()
        {
            Console.Write("Please enter number :");
             var taskId = int.Parse(Console.ReadLine());

            if (taskId > 0 && taskId <= taskIndex)
            {
                for (int i = taskId - 1; i < taskIndex - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                tasks[taskIndex - 1] = null;
                taskIndex--;
                Console.WriteLine("Task removed.");
            }else
            {
                Console.WriteLine("Invalid task number.");
            }



        }


    }

}
