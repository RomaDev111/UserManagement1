using System;
using UserManagement1.Services;

namespace UserManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			
			string filePath = "C:\\Users\\HP Victus\\Desktop\\Projects\\PCLesson\\UserManagement1\\UserManagement1\\Storage.txt";
            UserManagementService userService = new UserManagementService(filePath);
            Console.WriteLine("Welcome to the User registration Console App!");
			while (true)
			{
				Console.WriteLine("       Menu");
				Console.WriteLine("1. Add Credentials");
				Console.WriteLine("2. Show all Credentials");
				Console.WriteLine("3. Exit");

				Console.WriteLine("Please enter your choice: ");
				string choice = Console.ReadLine();

				switch (choice) 
				{
					case "1": 	
						userService.AddCredentials(filePath);
						break;
					case "2": 
						userService.ShowAllCredentials(filePath); 
						break;
					case "3":
                        Console.WriteLine("Thank you for using our app!");
						return;
					default:
						Console.WriteLine("Invalid choice. Please enter a valid option.");
						break;
                }
			}
        }
    }
}