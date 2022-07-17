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


        public static List<User> Users { get; set; } = new List<User>()
        {
            new User ("Super","Admin","admin@gmail.com","123321")
        };

        public static User AddUser(string name, string lastName, string email, string password  )
        {
            User user = new User(name, lastName, email,password);
            Users.Add(user);
            return user;
        }
        public static User GetUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            return null;
        }
       

       
        public static bool IsUserExistByEmailAndPassword(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool IsUserExistsByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }
        public static List<User> GetAll()
        {
            return Users;
        }

       
    }
}
