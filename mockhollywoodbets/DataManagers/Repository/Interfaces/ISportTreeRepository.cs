using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Interfaces
{
    public interface ISportTreeRepository : IDataRepository<SportTree>
    {
        IQueryable<SportTree> Get(long? sportid);
    }
}
