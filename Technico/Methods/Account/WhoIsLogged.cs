﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class WhoIsLogged
{

    public static void Execute(Owner loggedInOwner) // this method is called when someone had logged in so it can verify that the user exists
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

    }

}