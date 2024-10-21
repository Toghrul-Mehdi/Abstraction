using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class User :IAccount
    {

        private static int _nextid=1;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User[] users;


        public User()
        {
            
            users = new User[0];
            Id=_nextid++;
        }


        public void AddUser(User user,string fullname,string email,string password)
        {
            
            Array.Resize(ref users, users.Length+1);
            users[users.Length - 1] = user;
            Fullname = fullname;
            Email = email;
            Password = password;
        }


        public bool PasswordChecker(string password)
        {
            bool check = false;
            if(password.Length>=8 && Regex.IsMatch(password,@"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[0-9]"))
            {
                check = true;  
            }            
            return check;
        }

        public void ShowInfo()
        {
            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Id:{i+1}");
                Console.WriteLine($"FullName: {Fullname}");
                Console.WriteLine($"Email: {Email}");
            }
        }      


    }
}
