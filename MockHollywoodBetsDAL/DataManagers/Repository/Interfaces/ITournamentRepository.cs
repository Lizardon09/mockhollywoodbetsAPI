using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface ITournamentRepository : IDataRepository<Tournament>
    {
        IQueryable<Tournament> Get(long? sportid, long? countryid);
    }
}
