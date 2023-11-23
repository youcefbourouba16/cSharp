using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cour_2__OOP
{
    internal class Person
    {
        
        private int id;
        private string name;
        private string prenom;
        private DateTime  dn;
        static int nbrPerson  = 0;

       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public DateTime DN {
            get
            {
                return dn;

            }
             set { 
                var Y = DateTime.Today;
                var age = Y.Year - value.Year;
                if (age >= 18)
                {
                    dn = value;
                }
                else MessageBox.Show("L'age doit etre >= 18");
             } 
        }

        public Person()
        {
            nbrPerson += 1;
            MessageBox.Show("person numero" + nbrPerson);
        }
        
        public Person(int id, string name, string prenom, DateTime dN)
        {
            Id = id;
            Name = name;
            Prenom = prenom;
            DN = dN;
            new Person();
        }
        ///// Methods
        ///
        public int nbrabs(int mat)
        {
            return mat++;
        }
        public void afficher()
        {
            MessageBox.Show("id est :" + this.Id);
        }
        /// <summary>
        /// how to call static method from other class 
        /// </summary>
        /// <param name="a"></param>
        public static void afficheNomPrenom(int a)
        {
            MessageBox.Show("static =" + a);
        }
        
    }
}
