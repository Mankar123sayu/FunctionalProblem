using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class SwapTwoNumber
    {
        public void Swap()
        {
            Console.Write("Enter a first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping x: {x} and y: {y}");

            x = x + y;
            y = x - y;
            x = x - y;
            
            Console.WriteLine($"After Swapping x: {x} and y: {y}");
        }
    }
}
