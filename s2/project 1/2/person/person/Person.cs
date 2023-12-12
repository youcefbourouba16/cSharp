using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Person
    {
        public Person(string nom, string prenom, int phone, string email)
        {
            this.Nom = nom;
            this.prenom = prenom;
            this.phone = phone;
            this.email = email;
        }

        public String Nom { get; set; }
        public String prenom { get; set; }
        public int phone { get; set; }
        public String email { get; set; }



    }
}
