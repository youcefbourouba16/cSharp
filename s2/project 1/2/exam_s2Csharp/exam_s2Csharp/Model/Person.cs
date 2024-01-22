using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_s2Csharp.Model
{
    internal class Person
    {
        string name;
        string prenom;
        string email;
        string identite;
        string tel;
        DateTime dn;

        

        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Identite { get => identite; set => identite = value; }
        public string Tel { get => tel; set => tel = value; }
        public DateTime Dn { get => dn; set => dn = value; }
        public Person(string name, string prenom, string email, string identite, string tel, DateTime dn)
        {
            Name = name;
            Prenom = prenom;
            Email = email;
            Identite = identite;
            Tel = tel;
            Dn = dn;
        }
    }
}
