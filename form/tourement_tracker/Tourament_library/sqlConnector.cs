using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tourement_tracker;

namespace Tourament_library
{
    public class sqlConnector : IDataConnection
    {
        // todo - wire up the prize form
        public PrizeModel createPrize(PrizeModel model)
        {
           model.id= 1;
            return model;
        }
    }
}
