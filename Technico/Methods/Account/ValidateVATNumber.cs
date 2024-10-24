using System;
using Technico.Models;

namespace Technico.Methods.Account;

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
            isValid = userInput.Length == 9 && int.TryParse(userInput, out _);  // is valid will turn true if user input is a 9 digit
                                                                                // and it can turn into a integer with int.Tryparse
            if (!isValid)
            {
                Console.WriteLine("Please write a valid 9 digit number.");
            }
            else { 
                int vatNumber = int.Parse(userInput);
                if (Owner.RegisteredOwners.Any(o => o.VATNumber == vatNumber)) {  
                    Console.WriteLine("This Vat number is already registered. Please enter a different one.");
                    isValid = false;                        // Checks if there is an owner inside RegisteredOwners that has the Vat number
                }                                              // that was given in the userinput
            }

        } while (!isValid); 

        return userInput; // Return the valid VAT number
    }

    public static string Rules() // This method validates the Vat number when creating a property
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