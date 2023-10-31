using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class UserAndPassword
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public int gender { get; set; }

        

        public UserAndPassword(string username, string password, string nom, string prenom, string email, bool gender)
        {
            Password = password;
            Username = username;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.gender = gender;
        }
        public UserAndPassword()
        {
           
        }

        public UserAndPassword(string password, string username)
        {
            Password = password;
            Username = username;
        }
    }
}
