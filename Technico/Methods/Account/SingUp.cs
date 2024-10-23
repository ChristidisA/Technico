using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Menus;
using Technico.Models;

namespace Technico.Methods.Account;

public class SingUp
{
    public static void Execute()
    {
        Console.Clear();
        Console.WriteLine("Sign Up Menu");
        Navigation();

    }

    public static void Navigation() {
        string userInput;
        bool flag = false;
        Console.WriteLine("Enter 1 to continue your account registration \nEnter 2 to go back");
        do
        {
            userInput = Console.ReadLine();

            try
            {
                if (int.Parse(userInput) != 1 && int.Parse(userInput) != 2)
                {
                    Console.WriteLine("Invalid input. Please enter either 1 or 2");
                }
                else if (int.Parse(userInput) == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You chose to continue with the account creation.");
                    flag = true; // Exit loop
                    Registration();//Starts the account registration
                }
                else if (int.Parse(userInput) == 2)
                {
                    Console.WriteLine("You chose to go back");
                    flag = true; // Exit loop
                    WelcomeScreen.Execute();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter either 1 or 2.");
            }
        } while (flag == false);
    }

    public static void Registration() {
        string registerinfo;
        
        
        Owner owner = new Owner();

        registerinfo = ValidateVATNumber.Execute();
        owner.VATNumber = int.Parse(registerinfo);
        Console.Write("Please type your name: ");
        owner.Name = Console.ReadLine();
        Console.Write("Please type your surname: ");
        owner.Surname = Console.ReadLine();
        Console.Write("Please type your address: ");
        owner.Address = Console.ReadLine();        
        Console.WriteLine("Please enter your phone number (only digits):");
        registerinfo = ValidatePhoneNumber.Execute();
        owner.PhoneNumber = long.Parse(registerinfo);           
        Console.Write("Please type your email: ");
        owner.Email = Console.ReadLine();
        Console.Write("Please type your password: ");
        owner.Password = Console.ReadLine();
        owner.UserType = "User";

        Owner.AddOwner(owner);
        Console.Clear();
        Console.WriteLine("Account Registration Success");
        Console.WriteLine(owner.GetAccountDetails());
        Console.WriteLine("Enter anything to go back to the welcome screen");
        Console.Read();
        WelcomeScreen.Execute();






    }
}
