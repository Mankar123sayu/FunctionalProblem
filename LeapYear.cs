using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.Write("Enter a year: ");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x >= 1000 && x <= 9999)
            {
                if (x % 400 == 0) 
                {
                    Console.WriteLine($"{x} is a LeapYear");
                }
                else if (x % 100 == 0)
                {
                    Console.WriteLine($"{x} is not LeapYear");
                }
                else if (x % 4 == 0)
                {
                    Console.WriteLine($"{x} is a LeapYear");
                }
                else
                {
                    Console.WriteLine($"{x} is not LeapYear");
                }

            }
            else
            {
                Console.WriteLine("Enter Valid year");
            }

        }
    }
}
