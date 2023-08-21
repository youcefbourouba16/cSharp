using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tourement_tracker;

namespace Tourament_library
{
    public class textConnection : IDataConnection
    {
        // todo -wire up text files
        public PrizeModel createPrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
