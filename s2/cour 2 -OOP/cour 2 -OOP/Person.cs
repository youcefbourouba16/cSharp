using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cour_2__OOP
{
    internal class Person
    {
        /// <summary>
        ///  private read write only in this class
        ///  public in all classes of the project
        ///  protectd 
        /// </summary>
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
        /// <summary>
        /// /sans aragument
        /// </summary>
        public Person()
        {
            nbrPerson += 1;
            MessageBox.Show("person numero" + nbrPerson);
        }
        /// <summary>
        /// with argements
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="prenom"></param>
        /// <param name="dN"></param>
        public Person(int id, string name, string prenom, DateTime dN)
        {
            Id = id;
            Name = name;
            Prenom = prenom;
            DN = dN;
            new Person();
        }

        
    }
}
