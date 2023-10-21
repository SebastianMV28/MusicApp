using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class UserEntity
    {
        private int _id;
        private string _name, _email, _password, _telephoneNumber;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; } }

        public UserEntity(string name, string email, string password, string telephoneNumber) {
        
            _email = email;
            _password = password;
            _telephoneNumber = telephoneNumber;
            _name = name;
               
        }
    }
}
