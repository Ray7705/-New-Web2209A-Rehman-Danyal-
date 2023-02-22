using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{

    public class User
    {

        public string Username { private get; set; }
        public string FirstName { get;private set; }
        public string LastName { get;private set; }

        public string Password { get;private set; }

        //public Cart LastCart { get;private set; }


        public User(string userName, string firstName, string lastName , string password)
        {
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Password is null or empty");
            if(string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("User Name is null or empty");
            if(string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException("First Name is null or empty");
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Last Name is null or empty");

            Username= userName;
            FirstName= firstName;
            LastName= lastName;
            Password= password;
        }
        


    }
}
