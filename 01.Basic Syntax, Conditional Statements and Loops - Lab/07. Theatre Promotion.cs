namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (typeOfTheDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (typeOfTheDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            if (typeOfTheDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }

            Console.WriteLine($"{price}$");
        }
    }
}