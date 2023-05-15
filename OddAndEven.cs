using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class OddAndEven
    {
        public void Checking()
        {
            Console.Write("Enter a Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is Even number");
            }
            else
            {
                Console.WriteLine($"{x} is odd number");
            }

        }
    }
}
