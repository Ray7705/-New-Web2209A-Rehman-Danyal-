using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{

    public class User
    {

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get;set; }

        public string Password { get; set; }

        //public Cart LastCart { get;private set; }


        public User(string firstName, string lastName , string userName, string password)
        {
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Password is null or empty");
            if(string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("User Name is null or empty");
            if(string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException("First Name is null or empty");
            if(string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Last Name is null or empty");

            UserName= userName;
            FirstName= firstName;
            LastName= lastName;
            Password= password;
        }
        


    }
}
