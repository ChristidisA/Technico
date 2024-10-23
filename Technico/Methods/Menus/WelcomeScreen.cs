using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using static System.Net.Mime.MediaTypeNames;

namespace Technico.Methods.Menus;

public class WelcomeScreen
{
    public static void Execute()
    {

        string userInput;
        bool flag = false;
        Console.Clear();
        Console.WriteLine("Welcome to Technico");
        Console.WriteLine("You have to be logged in to view the menu");
        Console.WriteLine("If you dont have an account please create one");
        Console.WriteLine("Enter 1 to Sign In \nEnter 2 to Sing Up\nEnter 3 to exit the application");

        do
        {
            userInput = Console.ReadLine();

            try
            {
                if (int.Parse(userInput) != 1 && int.Parse(userInput) != 2 && int.Parse(userInput) != 3)
                {
                    Console.WriteLine("Invalid input. Please enter either 1 or 2 or 3.");
                }
                else if (int.Parse(userInput) == 1)
                {
                    Console.WriteLine("You chose to sign in.");
                    flag = true; // Exit loop
                    SingIn.Execute();
                }
                else if (int.Parse(userInput) == 2)
                {
                    Console.WriteLine("You chose to sign up.");
                    flag = true; // Exit loop
                    SingUp.Execute();
                }
                else if (int.Parse(userInput) == 3)
                {
                    Console.WriteLine("You chose to exit.");
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter either 1 or 2 or 3.");
            }
        } while (flag == false);

    }
}
