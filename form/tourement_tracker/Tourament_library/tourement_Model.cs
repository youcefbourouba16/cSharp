using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tourement_tracker
{
    public class tourement_Model
    {
        private String TourramentName;
        private double EntryFee;
        private List<teamModel> EnteredTeams=new List<teamModel>(); 
        private List<PrizeModel> Prizes=new List<PrizeModel>();
        public List<List<MatchupModel>> round{ get; set; }=new List<List<MatchupModel>>();


    
    }
}
