using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class Factors
    {
        public void Calculate()
        {
            Console.WriteLine("Enter a Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                Console.WriteLine($"{i} is a Factor of {x}");
            }
        }
    }
}
