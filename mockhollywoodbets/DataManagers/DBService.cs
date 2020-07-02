using MockHollywoodBets.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers
{
    public class DBService : IDataBase
    {
        private MockHollywoodBetsContext _dbContext;

        public DBService(MockHollywoodBetsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MockHollywoodBetsContext dbContext()
        {
            return _dbContext;
        }
    }
}
