namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            static void Main(string[] args)
            {
                string numberAsString = Console.ReadLine();

                int evenSum = GetSum(numberAsString, true);
                int oddSum = GetSum(numberAsString, false);

                int result = evenSum * oddSum;

                Console.WriteLine(result);

            }

            static int GetSum(string numbers, bool isEven)
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= 48 && numbers[i] <= 57)
                    {
                        int currentNumber = int.Parse(numbers[i].ToString());

                        if (currentNumber % 2 == 0 && isEven)
                        {
                            sum += currentNumber;
                        }
                        else if (numbers[i] % 2 != 0 && !isEven)
                        {
                            sum += currentNumber;
                        }
                    }

                }

                return sum;
            }
        }
    }
}