using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Users.Models
{
    public class User
    {

        private int _id;
        private string _name;
        private string _email;
        private string _password;

        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public User(string text)
        {

            string[] prop = text.Split('|');

            this._id = int.Parse(prop[0]);
            this._name = prop[1];
            this._email = prop[2];
            this._password = prop[3];

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }



    }
}
