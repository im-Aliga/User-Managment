using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment.ApplicationLogic.Validations;
using User_Managment.Database.Models;
using User_Managment.Database.Reposity;

namespace User_Managment.ApplicationLogic
{
    internal class Authentication
    {
        public static void Register()
        {
            string name = GetName();

            string lastname = GetLastName();

            string email = GetEmail();

            string password = GetPassword();



            if (UserValidations.IsValidName(name) &
                UserValidations.IsValidLastname(lastname) &
                UserValidations.IsValidEmail(email) &
                UserValidations.IsValidPassword(password))

            {
                User user = UserReposity.AddUser(name, lastname, email, password);
                Console.WriteLine($"User added to system, his/her details are : {user.GetUserInfoForUser()}");

            }

        }
        public static string GetName()
        {
            Console.Write("Please enter user's name : ");
            string name = Console.ReadLine();

            while (!UserValidations.IsValidName(name))
            {
                Console.Write("Please enter correct user's name : ");
                name = Console.ReadLine();
            }

            return name;
        }
        public static string GetLastName()
        {
            Console.Write("Please enter user's last name :");
            string lastname = Console.ReadLine();
            while (!UserValidations.IsValidLastname(lastname))
            {
                Console.Write("Please enter correct user's lastname : ");
                lastname = Console.ReadLine();

            }
            return lastname;
        }
        public static string GetEmail()
        {
            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();
            while (!UserValidations.IsValidEmail(email) || !UserValidations.IsUserEmailUnique(email))
            {
                Console.Write("Please enter correct user's email : ");
                email = Console.ReadLine();
            }
            return email;
        }
        public static string GetPassword()
        {
            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();

            while (!UserValidations.IsValidPassword(password))
            {
                Console.Write("Please enter correct user's password : ");
                password = Console.ReadLine();
            }
            Console.Write("Please enter user's confirm password : ");
            string confirmPassword = Console.ReadLine();
            while (!UserValidations.IsValidPasswordWithConfirm(password, confirmPassword))
            {
                Console.Write("Please enter correct user's confirm password ");
                confirmPassword = Console.ReadLine();

            }
            return password;
        }



        public static void Login()
        {
            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();

            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();


            if (UserReposity.IsUserExistByEmailAndPassword(email, password))
            {
                User user = UserReposity.GetUserByEmail(email);
                if(user is Admin)
                {
                    Dashboard.AdminPanel();
                }
                else if (user is User)
                {
                    Dashboard.UserPanel(email);
                }



            }
        }



    }
}
