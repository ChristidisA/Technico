using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class UpdateAccount
{
    public static void Update() {
        using (var context = new AppDbContext()) 
        {
            Console.WriteLine("You selected to update an account.");

            // Get the account’s VAT number to identify the account
            int vat = int.Parse(ValidateVATNumber.Rules());

            // Find the owner in the database by VAT number
            var accountToUpdate = context.Owners
                .FirstOrDefault(o => o.VATNumber == vat);

            if (accountToUpdate != null)
            {
                Console.WriteLine("Enter new details for the account (leave blank to keep current values):");

                // Update Name
                Console.WriteLine($"Current Name: {accountToUpdate.Name}");
                Console.Write("New Name: ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    accountToUpdate.Name = newName;
                }

                // Update Surname
                Console.WriteLine($"Current Surname: {accountToUpdate.Surname}");
                Console.Write("New Surname: ");
                string newSurname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newSurname))
                {
                    accountToUpdate.Surname = newSurname;
                }

                // Update Address
                Console.WriteLine($"Current Address: {accountToUpdate.Address}");
                Console.Write("New Address: ");
                string newAddress = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newAddress))
                {
                    accountToUpdate.Address = newAddress;
                }

                // Update Phone Number
                Console.WriteLine($"Current Phone Number: {accountToUpdate.PhoneNumber}");
                Console.Write("New Phone Number: ");
                string newPhoneInput = Console.ReadLine();
                if (long.TryParse(newPhoneInput, out long newPhone))
                {
                    accountToUpdate.PhoneNumber = newPhone;
                }

                // Update Email
                Console.WriteLine($"Current Email: {accountToUpdate.Email}");
                Console.Write("New Email: ");
                string newEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    accountToUpdate.Email = newEmail;
                }

                // Update Password
                Console.WriteLine($"Current Password: {accountToUpdate.Password}");
                Console.Write("New Password: ");
                string newPassword = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    accountToUpdate.Password = newPassword;
                }

                // Update User Type
                Console.WriteLine($"Current User Type: {accountToUpdate.UserType}");
                Console.Write("New User Type: ");
                string newUserType = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newUserType))
                {
                    accountToUpdate.UserType = newUserType;
                }

                // Save changes to the database
                context.SaveChanges();
                Console.WriteLine("Account updated successfully.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
