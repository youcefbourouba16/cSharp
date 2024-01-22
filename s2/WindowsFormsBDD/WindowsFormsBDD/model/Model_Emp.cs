using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBDD
{
    public class Model_Emp
    {
        string nomEmp;
        string prenomEmp;
        DateTime dnEmp;
        string  emailEmp;
        string  nomUlilis;
        string  modDePass;
        string IdStr;

        public string NomEmp { get => nomEmp; set => nomEmp = value; }
        public string PrenomEmp { get => prenomEmp; set => prenomEmp = value; }
        public DateTime DnEmp { get => dnEmp; set => dnEmp = value; }
        public string EmailEmp { get => emailEmp; set => emailEmp = value; }
        public string NomUlilis { get => nomUlilis; set => nomUlilis = value; }
        public string ModDePass { get => modDePass; set => modDePass = value; }
        public string IdStr1 { get => IdStr; set => IdStr = value; }

        public Model_Emp()
        {
            
        }

        public Model_Emp(string nomEmp, string prenomEmp, DateTime dnEmp, string emailEmp, string nomUlilis, string modDePass, string idStr)
        {
            this.nomEmp = nomEmp;
            this.prenomEmp = prenomEmp;
            this.dnEmp = dnEmp;
            this.emailEmp = emailEmp;
            this.nomUlilis = nomUlilis;
            this.modDePass = modDePass;
            IdStr = idStr;
        }

       
    }
}
