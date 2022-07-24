using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment.Database.Reposity;

namespace User_Managment.Database.Models
{
    internal class User
    {

        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Admin> Users { get; set; }

        public DateTime _registrationTime { get; set; }



        public User(string name, string lastName, string email, string password, int id)
        {

            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = id;

            _registrationTime = DateTime.Now;




        }
        public User(string name,string lastname)
        {
            Name=name;
            LastName = lastname;



        }
        public User(string name, string lastName, string email, string password)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = UserReposity.IdCounter;
            
        }

        public string GetUserInfoForUser()
        {
            return Name + " " + LastName + " " + Email + " " + _registrationTime;
        }

        public virtual string GetUserInfoForAdmin()
        {

            return Id + " " + Name + " " + LastName + " " + Email + " " + _registrationTime;
        }



    }
}
