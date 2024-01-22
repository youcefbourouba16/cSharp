using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_s2Csharp
{
    public class Etudiant
    {
        int mat;
        string nom;
        string prenom;
        char sexe;
        DateTime dn;

        public int Mat { get => mat; set => mat = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public DateTime Dn { get => dn; set => dn = value; }

        public Etudiant(int mat, string nom, string prenom, char sexe, DateTime dn)
        {
            Mat = mat;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Dn = dn;
        }
    }
}
