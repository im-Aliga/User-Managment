using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Managment.Database.Models
{
    internal class Admin :User
    {
        public Admin(string name, string lastName, string email, string password, int id)
            : base(name, lastName, email, password, id)
        {


        }

        public Admin(string name, string lastName, string email, string password)
            : base(name, lastName, email, password)
        {


        }

        public   string GetInfoForAdmin()
        {
             return Id + " " + Name + " " + LastName + " " + Email + " " + _registrationTime;
        }
    }
}
