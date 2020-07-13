using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IBettypeRepository : IDataRepository<Bettype>
    {
        IQueryable<Bettype> Get(long? tournamentid);
        IQueryable<Bettype> GetBettype(long? bettypeid);
    }
}
