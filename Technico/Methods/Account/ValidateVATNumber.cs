using System;

namespace Technico.Methods.Account
{
    public class ValidateVATNumber
    {
        public static string Execute()
        {
            string userInput;
            bool isValid;

            // Prompt the user for their VAT number
            Console.WriteLine("Please enter your VAT number:");
            do
            {
                userInput = Console.ReadLine();
                // Validate the VAT number directly within this method
                isValid = userInput.Length == 9 && int.TryParse(userInput, out _);

                if (!isValid)
                {
                    Console.WriteLine("Please write a valid 9 digit number.");
                }

            } while (!isValid);

            return userInput; // Return the valid VAT number
        }
    }
}