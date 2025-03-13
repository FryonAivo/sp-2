using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string Names { get; set; }
        public string Email { get; set; }
        public string FacultyNumber { get; set; }
        public UserRolesEnum Role { get; set; }

        private string _password;
        private int v1;
        private string v2;

        public string Password
        {
            get => _password;//Encoding.UTF8.GetString(Convert.FromBase64String(_password));
            set => _password = Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

        }

        public User(string names, string email, string facultyNumber, string password, UserRolesEnum role)
        {
            Names = names;
            Email = email;
            FacultyNumber = facultyNumber;
            Password = password;
            Role = role;
        }

        public User(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}