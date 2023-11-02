namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandInfo = command.Split(); // [0] -> "Add", [1] -> "3"

                if (commandInfo[0] == "Add")
                {
                    int number = int.Parse(commandInfo[1]);
                    integers.Add(number);
                }
                else if (commandInfo[0] == "Remove")
                {
                    int number = int.Parse(commandInfo[1]);
                    integers.Remove(number);
                }
                else if (commandInfo[0] == "RemoveAt")
                {
                    int index = int.Parse(commandInfo[1]);
                    integers.RemoveAt(index);
                }
                else if (commandInfo[0] == "Insert")
                {
                    int number = int.Parse(commandInfo[1]);
                    int index = int.Parse(commandInfo[2]);
                    integers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', integers));
        }
    }
}