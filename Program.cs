using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get password input from the user
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Initialize validation flags
            bool isValidLength = password.Length >= 8;
            bool hasDigit = false;
            bool hasUpper = false;

            // Check each character in the password
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
            }
            // List to collect missing rules
            List<string> missingRules = new List<string>();

            // Check validation flags and add missing rules
            if (!isValidLength)
            {
                missingRules.Add("At least 8 characters");
            }
            if (!hasDigit)
            {
                missingRules.Add("At least one number");
            }
            if (!hasUpper)
            {
                missingRules.Add("At least one uppercase letter");
            }

            // Output results
            if (missingRules.Count == 0)
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password. Missing rules:");
                foreach (string rule in missingRules)
                {
                    Console.WriteLine($"- {rule}");
                }
            }
        }
    }
}




