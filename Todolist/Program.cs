namespace Todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "3") {
                Console.Clear();
                Console.WriteLine("To Do List");

            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {taskList[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Exit program");

            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("Please enter your new task:");
                string input = Console.ReadLine();
                taskList.Add(input);
                
            } else if (option == "2")
            {
                Console.Clear();
                Console.WriteLine("What task do you want removed?");
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskList[i]}");
                }
                int input = Convert.ToInt32(Console.ReadLine());
                taskList.RemoveAt(input);
                
            }

            }

        }
    }
}
