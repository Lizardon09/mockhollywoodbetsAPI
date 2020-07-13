using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IEventRepository : IDataRepository<Event>
    {
        IQueryable<Event> Get(long? tournamentid);
        IQueryable<Event> GetEvent(long? eventid);
    }
}
