using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    //initial commit.
    class Program
    {
        static void Main(string[] args)
        {
            /* Asks user to enter a number-->each number entered is the string representation of the value
             and is converted to it's 32-bit signed integer equivalent; */
            Console.WriteLine("Please enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            int num9 = int.Parse(Console.ReadLine());
            int num10 = int.Parse(Console.ReadLine());

            /* sets the variable 'sum' is equal to the sum of each of the variables */
            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;

            /* This statement prints the interpolated string which means the value will replace the 'sum'
             variable. */
            Console.WriteLine($"The average is: {sum}");
        }
    }
}
