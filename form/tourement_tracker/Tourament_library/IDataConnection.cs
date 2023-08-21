using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tourement_tracker;

namespace Tourament_library
{
    /// <summary>
    /// 
    /// </summary>
    public  interface IDataConnection
    {
        PrizeModel createPrize(PrizeModel model);



    }
}
