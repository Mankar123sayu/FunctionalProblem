using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class FlipCoin
    {
        public void Flip()
        {
            int Haid = 0;
            int tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            double HeadPercentage;
            double TailPercentage;

            Console.Write("Enter the number of flip: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                for(int i=1; i<=x; i++)
                {
                    Random random = new Random();
                    int check = random.Next(2);
                    Console.WriteLine($"Flip gives: {check}");

                    if (check == 0)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }

                }
                Console.WriteLine($"HeadCount: {HeadCount}");
                Console.WriteLine($"TailCount: {TailCount}");

                HeadPercentage = HeadCount * 100 / x;
                TailPercentage = TailCount * 100 / x;

                Console.WriteLine($"HeadPercentage: {HeadPercentage}");
                Console.WriteLine($"TailPercentage: {TailPercentage}");
            }
        }
    }
}
