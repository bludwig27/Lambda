using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Log Some Lambdas!");
            Console.WriteLine();
            Console.WriteLine("Start by giving me 2 different double values.");
            Console.Write("Value 1: ");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value 2: ");
            double val2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            var sum = (double val1, double val2) => val1 + val2;
            Console.WriteLine($"\nAdding your two values using a lambda expression gives us {sum(val1,val2)}.");
            var product = (double val1, double val2) => val1 * val2;
            Console.WriteLine($"\nMultiplying them using a lambda expression gives us {product(val1,val2)}.");
            var smallerValue = (double val1, double val2) =>
            {
                if (val1 < val2) return val1;
                else return val2;
            };
            Console.WriteLine($"\nUsing a lambda statement, we can see that the smaller value is {smallerValue(val1, val2)}.");
            Console.WriteLine("\nFinished!");
        }
    }
}
