using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Menus;
using Technico.Models;

namespace Technico.Methods.Account;

public class SingIn
{
    public static void Execute()
    {
        Console.Clear();
        Console.WriteLine("Sign In Menu");
        Navigation();

    }

    public static void Navigation()
    {
        string userInput;
        bool flag = false;
        Console.WriteLine("Enter 1 to log in \nEnter 2 to go back");
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
                    Console.WriteLine("You chose to continue");
                    flag = true; // Exit loop
                    LogIn();//Starts the account registration
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

    public static void LogIn()
    {
        string username;
        string password;
        string userinput;

        while (true)
        {

            Console.Clear();
            Console.WriteLine("Log In Menu");
            Console.Write("Type your username: ");
            username = Console.ReadLine();
            Console.Write("Type your password: ");
            password = Console.ReadLine();

            Owner foundOwner = Owner.FindOwner(username, password);

            if (foundOwner != null)
            {
                Console.WriteLine("Login Successful!");
                Console.WriteLine(foundOwner.GetAccountDetails());
                MainMenu.Execute(foundOwner);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine("If you wish to retry, enter 1\nIf you wish to go back, enter 2");

                string userInput = Console.ReadLine();
                if (userInput == "2")
                {
                    WelcomeScreen.Execute(); // Go back to welcome screen
                    break; // Exit the loop
                }


            }
        }

    }
}

