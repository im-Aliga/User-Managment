using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using User_Managment.Database.Models;
using User_Managment.Database.Reposity;

namespace User_Managment.ApplicationLogic.Validations
{
    internal static class UserValidations
    {
        public static bool IsValidName(string name)
        {
            string patternName = @"(?=^.{3,30}$)([A-Z]+[a-z]+)";
            Regex regexName = new Regex(patternName)  ;
            if (regexName.IsMatch(name))
            {
                return true;
            }
            Console.WriteLine("The name you entered is incorrect, make sure the name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");
            return false;
        }
        public static bool IsValidLastname(string lastname)
        {
            string patternSurname = @"(?=^.{3,30}$)([A-Z]+[a-z]+)";
            Regex regexSurname = new Regex(patternSurname);
            if (regexSurname.IsMatch(lastname))
            {
                return true ;
            }
            Console.WriteLine("The last name you entered is incorrect, make sure that the last name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            string patternEmail = @"^([a-zA-Z0-9]{10,30})(@code\.edu\.az)$";
            Regex regexEmail = new Regex(patternEmail);
            if (regexEmail.IsMatch(email))
            {
                return true;
            }
            Console.WriteLine("Receent can consist of only letters and numbers, the total length can be min 10 max 30,");
            Console.WriteLine("Separator - there must be an @ in between");
            Console.WriteLine("Domain - can only end with 'code.edu.az'");
            return false;

        }
        public static bool IsValidPassword(string password)
        {
            string patternPassword = @"^(?=.*[A - Z])(?=.*[a - z])(?=.*\d)(?=.*?[!@#$%^&*()_+<>?])[A-Za-z\d!@#$%^&*()_+<>?]{6,50}$";

            Regex regexPassword=new Regex(patternPassword);
            if (regexPassword.IsMatch(password))
            {
                return true;
            }
            Console.WriteLine("Password - Must contain at least one uppercase letter, one lowercase letter, and a number and cannot be less than 8 in length.");
            return false;
        }
        public static bool IsValidPasswordWithConfirm( string password,string confirmPassword)
        {       
            if (password == confirmPassword)
            {
                return true;
            }

            Console.WriteLine("Password is not match");

            return false;
        }
        public static bool IsUserEmailUnique(string email)
        {
            if(!UserReposity.IsUserExistsByEmail(email))
            {
                return true;

            }
            Console.WriteLine("Email alredy exits");
            return false;
        }

    }
    
}
