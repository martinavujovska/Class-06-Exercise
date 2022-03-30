using System;

namespace class6exercise
{
    class Program
    {
        static void NumberStats(double number)
        {
            bool isNegative = number < 0;
            bool isDecimal = number % 1 > 0;
            string type = isDecimal ? "Decimal" : "Integer";
            bool isEven = number % 2 == 0;
            Console.WriteLine($"Stats for number: {number}");
            Console.WriteLine($"Is {number} negative: {isNegative}.");
            Console.WriteLine($"{number} is {type}");
            Console.WriteLine($"Is {number} even: {isEven}");
        }
        static bool UserInterface()
        {
            Console.WriteLine("Enter a number:");
            double number;
            bool isNumber = double.TryParse(Console.ReadLine(), out number);
            if (!isNumber)
            {
                Console.WriteLine("That wasn't a number. Pls try again.");
                return false;
            }
            NumberStats(number);
            Console.WriteLine("Press any key to try again or X to exit.");
            if (Console.ReadLine().Equals("X", StringComparison.InvariantCultureIgnoreCase))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            while (!UserInterface()) ;
            Console.WriteLine();
        }
    }
}
