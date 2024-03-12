using System;

namespace UserManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = "C:\\Users\\HP Victus\\Desktop\\Projects\\PCLesson\\UserManagement1\\UserManagement1\\Storage.txt";
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
						AddCerdentials(filePath);
						break;
					case "2": 
						ShowAllCredentials(filePath); 
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

		static void AddCerdentials(string filePath)
		{
            Console.WriteLine("\n Adding Credentials: ");
			Console.Write("Enter your username: ");
			string userName = Console.ReadLine();
			Console.Write("Enter your password: ");
			string password = Console.ReadLine();

            try
			{
				using (StreamWriter writer = new StreamWriter(filePath, true))
				{
					writer.Write($"Username: {userName} Password: {password}");
					writer.WriteLine();
				}
				Console.WriteLine("Your username and password are saved");
			}
			catch (Exception)
			{

                Console.WriteLine($"An error occured while saving");
            }
		}

		static void ShowAllCredentials(string filePath)
		{
            Console.WriteLine("\n All Credentials: ");
			try
			{
				using (StreamReader reader = new StreamReader(filePath))
				{
					string line;
					while((line = reader.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
				}
			}
			catch (Exception)
			{

                Console.WriteLine("Error occured while reading Credentials.");
            }
        }

    }
}