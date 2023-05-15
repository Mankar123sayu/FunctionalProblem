using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter a range: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //1 / 1 + 1 / 2 + 1 / 3 + ... +1 / x
           // 1/1 + 1/2 + 1/3 + 1/4 
           for(int i = 1; i <= x; i++)
            {
                Console.Write($"1/{i} +");
            }
        }
    }
}
