using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class ValidatePhoneNumber
{
    public static string Execute() {
        bool flag = false;
        string phone;

        do
        {

            phone = Console.ReadLine(); // Read input inside the loop

            // Check if the input is numeric
            if (!phone.All(char.IsDigit))
            {
                Console.WriteLine("Please enter only digits.");
            }
            else if (phone.Length < 5 || phone.Length > 11) // Check if the length is at least 5 digits
            {
                Console.WriteLine("Invalid input. Please enter a real number.");
            }
            else
            {
                try
                {
                    Console.WriteLine("Phone number accepted.");
                    flag = true; // Set flag to true to exit the loop
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please use only digits.");
                    flag = false; // In case of a format exception, keep the loop running
                }
            }
        } while (flag == false);
        return phone;

    }
}
