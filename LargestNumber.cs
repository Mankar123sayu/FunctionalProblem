using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class LargestNumber
    {
        public void Number()
        {
            Console.Write("Enter a first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine($"{x} is gretest among all");
                }
                else
                {
                    Console.WriteLine($"{z} is gretest among all");
                }
            }
            else if (y > z)
            { 
                if (y > x)
                {
                    Console.WriteLine($"{y} is gretest among all");
                }
                else
                {
                    Console.WriteLine($"{x} is gretest among all");
                }
              
            }
            else
            {
                Console.WriteLine($"{z} is gretest among all");
            }
            

            
        }
    }
}
