using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class MatchScorecs
    {
        static void Main(string[] args)
        {
            var regEx = new Regex(@"^((([1-9]?[0-9](\.[0-9]+)?)|100)\%)$");
            string score;

            do
            {
                Console.Write("Enter Score (type . to quit):");
                score = Console.ReadLine();

                if (regEx.IsMatch(score))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            while (score != ".");

            Console.Read();
        }

    }
}
