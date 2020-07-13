using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers
{
    public interface IDataBase
    {
        MockHollywoodBetsContext dbContext();
    }
}

