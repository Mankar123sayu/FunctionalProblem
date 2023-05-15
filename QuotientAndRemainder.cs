using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class QuotientAndRemainder
    {
        public void Divide()
        {
            Console.Write("Enter a Divisor: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Dividend: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int Quotient = y / x;
            int Remainder = y % x;

            Console.WriteLine($"Remainder: {Remainder}");
            Console.WriteLine($"Quotient: {Quotient}");


        }
    }
}
