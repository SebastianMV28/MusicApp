using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class UserEntity
    {
        public string _id;
        public string _name, _email, _password, _telephoneNumber;
        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; } }

        public UserEntity(string id)
        {
            _id = id;
        }

        public UserEntity(string id,string name, string email, string password, string telephoneNumber) {
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

        public string RegisterUser()
        {
            Console.WriteLine("Add your id");
            string idUser = _id;
            Console.WriteLine("Add your name");
            string nameUser = _name;
            Console.WriteLine("Add your telephone");
            string telephoneUser = _telephoneNumber;
            Console.WriteLine("Add your email");
            string emailUser = _email;
            Console.WriteLine("Add your password");
            return idUser;
        }    
            


        public bool SingAccess()
        {
            bool valid;
            if (string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password) ){
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }

    }
}
