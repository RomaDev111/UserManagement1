using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement1.Services
{
    public class UserManagementService
    {
        private string _filePath;

        public UserManagementService(string filePath)
        {  
            _filePath = filePath; 
        }
        public void AddCredentials(string filePath)
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

        public void ShowAllCredentials(string filePath)
        {
            Console.WriteLine("\n All Credentials: ");
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
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
