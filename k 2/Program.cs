using System;


namespace k1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");

            string userInput = Console.ReadLine();

            int UserNumber = int.Parse(userInput);

            for (int i = 1; i <= UserNumber; i++)
            {
               // Console.WriteLine(i + " ");

                int remainder = i % 2;

                if (remainder == 1)

                {

                    if (i == 3)

                    {

                        Console.WriteLine($"welcome to {i}");

                    }

                    else if (i == 7)

                    {

                        Console.WriteLine($"welcome to {i}");

                    }

                    else

                    {
                        Console.WriteLine($"The number is neither 3 nor 7: {i}");
                    }

                }
            }
        }
    }
}