using Chevalier.Utility.Commands;
using StoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.ViewModels
{
    public class LoginViewModel
    {
        public ObservableCollection<User> Users { get; }
        public DelegateCommand LogInCommand { get; }
        public DelegateCommand SignUpCommand { get; }

        public LoginViewModel()
        {
            Users = new ObservableCollection<User>();
            {
                Users.Add(new User("Rehman", "Basharat", "ray555", "Password123"));
            }
            LogInCommand = new DelegateCommand(Login);
            SignUpCommand = new DelegateCommand(SignUp);
        }
        

        private void Login(object _)
        {
            User foundUser = Users.FirstOrDefault(user => user.Username == Username && user.Password == Password);
        }
        private void SignUp(object _)
        {

        }

    }
}
