using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class SingIn
{
    public static void Execute()  // Log in
    {
        Console.Clear();
        Console.WriteLine("Sign In Menu");

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

            Owner loggedInOwner = FindOwner.ByMailPass(username, password);

            if (loggedInOwner != null)
            {
                Console.WriteLine("Login Successful!");
                Console.WriteLine(AccountDetails.Get(loggedInOwner));
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine("If you wish to retry, enter 1\nIf you wish to not log in, enter 2");

                string userInput = Console.ReadLine();
                if (userInput == "2")
                {
                    break; // Exit the loop
                }
            }
        }
    }        
}

