using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resirvation
{
    public class ReservationData
    {
        public ReservationData(string nom,
            string penom,
            string depart,
            string distination, 
            string aller_reteur,
            DateTime dtDepart,
            DateTime dtAriver, 
            bool passport,
            bool buisness,
            DateTime dt_delivrance,
            DateTime dt_Expriation, 
            decimal bagage)
        {
            Nom = nom;
            Penom = penom;
            this.depart = depart;
            this.distination = distination;
            Aller_reteur = aller_reteur;
            DtDepart = dtDepart;
            DtAriver = dtAriver;
            this.passport = passport;
            this.buissnes = buisness;
            Dt_delivrance = dt_delivrance;
            Dt_Expriation = dt_Expriation;
            Bagage = bagage;
        }

        public string Nom { get; set; }
        public string Penom { get; set; }
        public string depart { get; set; }
        public string distination { get; set; }
        public string Aller_reteur { get; set; }
        public DateTime DtDepart { get; set; }
        public DateTime DtAriver { get; set; }
        public bool passport { get; set; }
        public bool buissnes { get; set; }
        public DateTime Dt_delivrance { get; set; }
        public DateTime Dt_Expriation { get; set; }
        public decimal Bagage { get; set; }

    }
}
