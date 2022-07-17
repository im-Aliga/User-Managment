using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment.Database.Models;

namespace User_Managment.Database.Reposity
{
    internal class UserReposity
    {


        private static List<User> Users { get; set; } = new List<User>();

        public static User AddUser(string name, string lastName, string email, string password ,DateTime time )
        {
            User user = new User(name, lastName, email,password,time);
            Users.Add(user);
            return user;
        }
        
    }
}
