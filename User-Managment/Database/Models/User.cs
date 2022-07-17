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
        public DateTime RegistrationTime { get; set; }


        public User(string name, string latsname, string email, string password, DateTime time )
        {
            Id = _idcounter;
            _idcounter++;
            Name = name;
            LastName = latsname;
            Email = email;
            Password = password;
            RegistrationTime = time;
        }

    }
}
