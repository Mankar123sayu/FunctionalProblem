using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class PowerofTwo
    {
      public void Power()
        {
            Console.Write("Enter the Power of Two: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= x; i++)
            {
                
                Console.WriteLine("The value of 2^{0}: {1}", i, Math.Pow(2, i));
                
            }
        }
    }
}
