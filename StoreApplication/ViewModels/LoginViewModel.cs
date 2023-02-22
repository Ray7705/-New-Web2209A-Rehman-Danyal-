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
            LogInCommand = new DelegateCommand(Login);
            SignUpCommand = new DelegateCommand(SignUp);
        }
        

        private void Login(object _)
        {

        }
        private void SignUp(object _)
        {

        }

    }
}
