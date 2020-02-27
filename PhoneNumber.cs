using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class PhoneNumber
    {
        static void Main(string[] args)
        {
            var regEx = new Regex(@"[0-9]{10}");

            string phoneNumber, cleanNumber;

            do
            {
                Console.Write("Enter Phone Number (type . to quit): ");
                phoneNumber = Console.ReadLine();

                cleanNumber = phoneNumber.Replace(" ", "").Replace("-", ""); //

                Console.WriteLine("* " + cleanNumber + " *");

                if (regEx.IsMatch(cleanNumber))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            while (phoneNumber != ".");
        }
    }
}
