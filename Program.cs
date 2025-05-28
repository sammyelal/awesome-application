using System;

namespace AwesomeApplication
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            var input2 = Console.ReadLine();

            if (int.TryParse(input1, out var a) && int.TryParse(input2, out var b))
            {
                int sum = AddNumbers(a, b);
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }

        public static int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
