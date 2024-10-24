using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Methods.Property_Item;

public class ValidateInt
{ 

    public static string Year( ){  // Validates if the year that was written is valid.
        bool flag=false;
        string input;
        do {
            input = Console.ReadLine();
            flag = input.Length == 4 && int.TryParse(input, out _);
            if (!flag) {
                Console.WriteLine("Please enter a valid year.");
            }
        } while (flag ==  false);
    return input;
    }
    
}
