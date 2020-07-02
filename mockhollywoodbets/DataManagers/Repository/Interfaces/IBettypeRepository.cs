using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Interfaces
{
    public interface IBettypeRepository : IDataRepository<Bettype>
    {
        IQueryable<Bettype> Get(long? tournamentid);
    }
}
