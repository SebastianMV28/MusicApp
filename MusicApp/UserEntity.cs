using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class UserEntity
    {
        public int _id;
        public string _name, _email, _password, _telephoneNumber;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; } }

        public UserEntity(int id)
        {
            _id = id;
        }
        public UserEntity(string name)
        {
            _name = name;
        }
        public UserEntity(int id,string name, string email, string password, string telephoneNumber) {
            _id = id;
            _name = name;
            _telephoneNumber = telephoneNumber;
            _email = email;
            _password = password;       
        }
        public UserEntity(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public UserEntity() { }

        //------------------------------------------
        public bool SingAccess()
        {
            bool valid= true;
            if (string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password) ){
                valid = false;
            }
            else
            {
                valid = true;
            }
            return true;
        }

    }
}
