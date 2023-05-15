using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class VowelAndConsonant
    {
        public void Alphabet()
        {
            Console.Write("Enter a Character: ");
            char x = Convert.ToChar(Console.ReadLine());

            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U') 
            {
                Console.WriteLine($"{x} is a vowel");
            }
            else if (((x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z')))
            {
                Console.WriteLine($"{x} is a consonant");
            }
            else
            {
                Console.WriteLine("Enter a valid alphabet");
            }

        } 
    }
}
