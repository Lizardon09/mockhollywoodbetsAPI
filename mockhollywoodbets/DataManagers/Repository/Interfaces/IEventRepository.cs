using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Interfaces
{
    public interface IEventRepository : IDataRepository<Event>
    {
        IQueryable<Event> Get(long? tournamentid);
    }
}
