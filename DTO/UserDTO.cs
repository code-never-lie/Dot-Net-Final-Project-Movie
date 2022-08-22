using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.DTO
{
    class UserDTO
    {
        private string _userID;
        private string _username;
        private string _password;
        private string _role;
        private string _age;

        public string UserID { get => _userID; set => _userID = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public string Age { get => _age; set => _age = value; }
    }
}
