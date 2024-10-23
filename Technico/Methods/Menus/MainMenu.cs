using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Menus;

public class MainMenu
{

    public static void Execute(Owner loggedInOwner)
    {
        Console.Clear();
        if (loggedInOwner != null)
        {
            Console.WriteLine($"Logged in user: {loggedInOwner.Name} {loggedInOwner.Surname}");
        }
        else
        {
            Console.WriteLine("No user is logged in.");
        }
        // Here you can add more options for the user to interact with {loggedInOwner.Name} {loggedInOwner.Surname}
        // ShowOptions();
    }
    /*
            private void ShowOptions()
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Log Out");
                // Add more options as needed

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine(loggedInOwner.GetAccountDetails());
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Execute(); // Call Execute to refresh the main menu
                        break;
                    case "2":
                        WelcomeScreen.Execute(); // Log out and return to welcome screen
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        ShowOptions(); // Show options again
                        break;
                }
            }*/
}