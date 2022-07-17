using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Managment.Database.Models
{
    internal class User
    {
        private static int _idcounter = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  DateTime _registrationTime { get; set; }
        


        public User(string name, string lastName, string email, string password)
        {
            Id = _idcounter;
            _idcounter++;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            _registrationTime=DateTime.Now;
            
            

        }
        public string GetUserInfoForUser()
        {
            return Name + " " + LastName + " " + Email+" "+_registrationTime;
        }
        public string GetUserInfoForAdmin()
        {

            return Id + " " + Name + " " + LastName + " " + Email + " " + _registrationTime;
        }
        
     

    }
}
