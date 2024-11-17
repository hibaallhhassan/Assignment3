using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp69
{
    //Q2
    public class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
         
        public UserAccount(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
        
        public UserAccount(UserAccount account)
        {
            Email = account.Email;
            Username = account.Username;
            Password = account.Password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList to store user accounts
            ArrayList accounts = new ArrayList();
            // Add some user accounts
            accounts.Add(new UserAccount("user1@example.com", "user1",
            "password1"));
            accounts.Add(new UserAccount("user2@example.com", "user2",
            "password2"));
            accounts.Add(new UserAccount("user3@example.com", "user3",
            "password3"));
            // User input for username and password
            Console.WriteLine("Enter Username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string inputPassword = Console.ReadLine();
            // Check for valid credentials
            bool isValid = false;
            foreach (UserAccount account in accounts)
            {
                if (account.Username == inputUsername && account.Password
                == inputPassword)
                {
                    isValid = true;
                    break;
                }
            }
            // Display result
            if (isValid)
            {
                Console.WriteLine("Correct credentials!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }
            Console.ReadKey();
        }
    }
}