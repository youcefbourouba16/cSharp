using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tourement_tracker
{
    public class teamModel
    {
        /// <summary>
        /// has the the information of players
        /// </summary>
        public List<person> team_member { get; set; }=new List<person>() { };
        public String TeamName { get; set; }
    }
}