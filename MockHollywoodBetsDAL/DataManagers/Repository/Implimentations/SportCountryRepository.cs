using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

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
            throw new NotImplementedException();
        }

        public int Delete(Country entity)
        {
            throw new NotImplementedException();
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

        public int Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
