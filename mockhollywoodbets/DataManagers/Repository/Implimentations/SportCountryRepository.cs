using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class SportCountryRepository : ISportCountryRepository
    {

        private IDataBase _dbService;

        public SportCountryRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country entity)
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

        public IQueryable<Country> GetAll(long id)
        {
            return _dbService.dbContext().Country.FromSqlInterpolated($"EXECUTE dbo.GetCountryBySportId {id}").AsQueryable();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
