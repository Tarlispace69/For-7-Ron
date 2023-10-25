using System;

namespace For_7_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0, i = 0, sum = 0;

            for(i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number:");
                input = int.Parse(Console.ReadLine());

                if (input / 10 != 0 && input % 2 == 0)
                {
                    sum += input;
                }
            }
            Console.WriteLine($"The sum of even dual-digit numbers is: {sum}");
            Console.ReadLine();
        }
    }
}
