﻿using System.Numerics;
using Technico.Methods.Account;
using Technico.Methods.PropertyItem;
using Technico.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Technico.Methods.Property_Item;
using Technico.Methods.Property_Repair;
using Technico.Methods;

var context = new AppDbContext();
var fakedata = new FakeData(context);
Console.WriteLine("Welcome to Technico");

// ------------------------- Property Owner Services -----------------------------------------------------------------

//SingUp.Execute();    //Creates account
//SingIn.Execute();  //Logs In the account

//FindOwner.AuthenticateOwner("admin","admin");  //Authenticates the credentials of a user

//AccountDetails.DisplayUserDetails(111222333);         // Displays users by id!
//AccountDetails.PrintAllUsers();              // Prints all users!

// AccountHoldings.Show();                    // Enter the vat number and it will return all the properties assinged to it

 //UpdateAccount.Update();                    // Updates a user's information by entering his vat number
 //DeleteAccount.Delete();                   // Delets users and all his properties


//------------------------- Property Item Services -----------------------------------------------------------------


// PropertyDetails.View(1);       // View command  ---   Displays the propertys details based on the id you give it

// CreateProperty.Create();       // Create command ---- Submits a new property in the system

// DeleteProperty.Delete();         // Deletes a property if you give the correct vat number and address

// UpdateProperty.Update(5);         // Updates a property's information - Use PropertyId to select the property


// ------------------------- Property Repair Services -----------------------------------------------------------------

// RepairCreation.Create();              // Creates a repair only if the vat number and the repairAddress match an existing home

// AccountRepairs.ShowAll();             // Shows all repair records that are programmed for a certain user

// RepairUpdate.Update(2);               // Updates a repair records based on the id that is given

//  RepairDelete.Delete(5);              // Deletes a repair record based on the id that is given

// RepairSearch.Search(1);                // Searches and prints  a specific repair record
// RepairSearch.All();                    // Searches and prints all repair records

