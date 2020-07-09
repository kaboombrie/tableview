/* Brie Prater
06/26/2020
CIS 353
Professor Cain
Assignment 4.2 B */

using System;
namespace CIS353
{
	public class Account
	{
		private int accountNum; // private variable for user input
		private double balance; // private variable for user input
		public void getData() // method to get account date from user
		{
			Console.WriteLine("Please enter the account number: ");
			accountNum = Convert.ToInt32(Console.ReadLine()); // sets input to accountNum variable
			Console.WriteLine("Please enter the corresponding balance: ");
			balance = Convert.ToDouble(Console.ReadLine()); // sets input to balance variable
		}
		public void Search(int Find) // method to search for account number, passing find variable that contains user input
		{
	
			if (accountNum == Find) // boolean determines if accountNum variable is same as Find variable
			{
				Console.WriteLine("Account number {0} has a balance of {1:C02}.", accountNum, balance); // if true displays account number and balance
			}
		}
		public void Display() // method to display data in a column format
		{
			var table = new System.Text.StringBuilder(); // creates a new string builder
			table.Append(String.Format("{0,8} {1,12:C02}\n", accountNum, balance)); // uses string builder to space data into columns
			Console.WriteLine(table); // displays data
		}

	}
	public class Test
	{
		public static void Main(string[] args) // Main method
		{
			int Find; // variable to hold user input
			Account[] listInfo = new Account[5]; // instantiates array of objects
			for (int x = 0; x < 5; x++) // for loop to obtain 5 account numbers and balances
			{
				listInfo[x] = new Account();// set array object reference to instance of class objects
				listInfo[x].getData(); // calls getData method and stores user input in array index x
			}
			Console.WriteLine("Please enter the account number to search for: "); // asks for user input
			Find = Convert.ToInt32(Console.ReadLine()); // sets user input to Find variable
			for (int x = 0; x < 5; x++) // for loop to check through all array indexes
			{
				listInfo[x].Search(Find); // calls Search method and passes Find variable
			}
			var title = new System.Text.StringBuilder(); // creates a new string builder
			title.Append(String.Format("{0,8} {1,12}\n", "Account", "Balance")); // uses string builder to create titles for columns
			Console.WriteLine(title); // displays title 
			for (int x = 0; x < 5; x++) // for loop to iterate through all indexes in array
			{
				listInfo[x].Display(); // calls Display method
			}
		}
	}
}