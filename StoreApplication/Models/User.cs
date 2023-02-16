using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{

    internal class User
    {

           public int Id { get;private set; }
        public string? FirstName { get;private set; }
        public string? LastName { get;private set; }

        public Cart? LastCart { get;private set; }

        


    }
}
