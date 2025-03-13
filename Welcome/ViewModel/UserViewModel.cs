using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    internal class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Names => _user.Names;
        public string Email => _user.Email;
        public string FacultyNumber => _user.FacultyNumber;
        public UserRolesEnum Role => _user.Role;

        public string Password => _user.Password;


    }
}