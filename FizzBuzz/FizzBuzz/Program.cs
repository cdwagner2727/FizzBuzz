using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to fizz and or buzz: ");
            string amount = Console.ReadLine();
            TryBuzz(amount);

            string wait = Console.ReadLine();
        }

        public static void FizzBuzzer(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.Write(System.Environment.NewLine);
            }
        }

        public static void TryBuzz(string input)
        {
            int iAmount = 0;
            if (Int32.TryParse(input, out iAmount))
            {
                FizzBuzzer(iAmount);
            }
            else
            {
                Console.WriteLine("Invalid input; please try entering a valid integer: ");
                TryBuzz(Console.ReadLine());
            }
        }
    }
}
