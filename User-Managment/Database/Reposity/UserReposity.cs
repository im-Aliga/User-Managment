using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment.Database.Models;

namespace User_Managment.Database.Reposity
{
    internal  class UserReposity
    {
        private static int _idCounter;
        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }

        public static List<User> Users { get; set; } = new List<User>()
        {
            new User ("Ali","Aliyev","Ali@gmail.com","123321"),
            new Admin("Super","Admin","admin@gmail.com","321123")

        };

        public static User AddUser(string name, string lastName, string email, string password)
        {
            User user = new User(name, lastName, email, password, IdCounter);
            Users.Add(user);
            return user;
        }



        public static User AddUser(string name, string lastName, string email, string password, int id)
        {
            User user = new User(name, lastName, email, password, id);
            Users.Add(user);
            return user;
        }



        public static User AddUser(User user)
        {
            Users.Add(user);
            return user;
        }

        public static User AddUser(Admin user)
        {
            Users.Add(user);
            return user;
        }


        public static List<User> GetAll()
        {
            return Users;
        }
        public  static void ShowAdmin()
        { List<User> users = GetAll();
            foreach(User user in users)
            {
                if(user is Admin)
                {
                    Console.WriteLine(user.GetUserInfoForAdmin());
                }
               

            }

        }
        public static int GetUserCount()
        {
            return Users.Count;
        }
        public static User UpdateForUser(string email,User user)
        {   User useruser=UserReposity.GetUserByEmail(email);
            useruser.Name = user.Email;
            useruser.LastName = user.LastName;
            return useruser;


        }
        public static User UpdateForAdmin(string email ,Admin admin)
        {
            User adminadmin = UserReposity.GetUserByEmail(email);
            adminadmin.Name = admin.Name;
            adminadmin.LastName=admin.LastName;
            return adminadmin;



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

        public static void Delete(User user)
        {
            Users.Remove(user);
        }


    }
}
