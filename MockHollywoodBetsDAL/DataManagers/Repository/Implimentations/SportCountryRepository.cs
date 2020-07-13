using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;
using Dapper;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Implimentations
{
    public class SportCountryRepository : ISportCountryRepository
    {

        private IDataBase _dbService;

        public SportCountryRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Country entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertCountry {entity.Name},{entity.Logo}");
                return result;
            }
        }

        public int Update(Country entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateCountry {entity.Id},{entity.Name},{entity.Logo}");
                return result;
            }
        }

        public int Delete(Country entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteCountry {entity.Id}");
                return result;
            }
        }

        public Country Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Country> GetAll()
        {
            return _dbService.dbContext().Country.FromSqlInterpolated($"EXECUTE dbo.GetAllCountries").AsQueryable();
        }

        public IQueryable<Country> GetAll(long? id)
        {
            return _dbService.dbContext().Country.FromSqlInterpolated($"EXECUTE dbo.GetCountryBySportId {id}").AsQueryable();
        }

        public IQueryable<Country> Get(long? countryid)
        {
            return _dbService.dbContext().Country.FromSqlInterpolated($"EXECUTE dbo.GetCountryByCountryId {countryid}").AsQueryable();
        }
    }
}
