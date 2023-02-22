using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{

    public class User
    {

        public int Username { private get; set; }
        public string FirstName { get;private set; }
        public string LastName { get;private set; }

        public string Password { get;private set; }

        //public Cart LastCart { get;private set; }


        public User(int userName, string firstName, string lastName , string password)
        {
            Username= userName;
            FirstName= firstName;
            LastName= lastName;
            Password= password;
        }
        


    }
}
