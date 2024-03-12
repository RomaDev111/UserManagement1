using UserManagement1.Models;

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
            string username = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username should not be empty");
                return;
            }
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(password) || password.Length < 9)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
            }
            User user = new User();
            user.Username = username;
            user.Password = password;
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write($"Username: {user.Username} Password: {user.Password}");
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
