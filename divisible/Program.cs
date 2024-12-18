using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisible
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 9 == 0)
            {
                Console.WriteLine("Divisible by 9");
            }
            else
            {
                Console.WriteLine("Not divisible by 9");
            }
        }
    }
}
