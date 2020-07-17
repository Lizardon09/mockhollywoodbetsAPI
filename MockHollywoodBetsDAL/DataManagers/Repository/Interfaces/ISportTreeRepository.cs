using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface ISportTreeRepository : IDataRepository<SportTree>
    {
        IQueryable<SportTree> Get(long? sportid);

        int AddSportCountry(SportCountry entity);
        int UpdateSportCountry(SportCountry entity);
        int DeleteSportCountry(long? id);

        IQueryable<SportCountryInfo> GetAllSportCountryInfo();
        IQueryable<SportCountryInfo> GetSportCountryInfo(long? sportcountryid);

    }
}
