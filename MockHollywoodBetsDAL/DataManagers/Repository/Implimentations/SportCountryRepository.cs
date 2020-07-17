using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;
using Dapper;
using MockHollywoodBetsDAL.CustomModels;

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
                return result + 1;
            }
        }

        public int Update(Country entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateCountry {entity.Id},{entity.Name},{entity.Logo}");
                return result + 1;
            }
        }

        public int Delete(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteCountry {id}");
                return result + 1;
            }
        }

        public int AddSportCountry(SportCountry entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertSportCountry {entity.SportId},{entity.CountryId}");
                return result + 1;
            }
        }

        public int UpdateSportCountry(SportCountry entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateSportCountry {entity.SportCountryId},{entity.SportId},{entity.CountryId}");
                return result + 1;
            }
        }

        public int DeleteSportCountry(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteSportCountry {id}");
                return result + 1;
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

        public IQueryable<SportCountryInfo> GetAllSportCountryInfo()
        {
            return _dbService.dbContext().SportCountryInfo.FromSqlInterpolated($"EXECUTE dbo.GetAllSportCountryInfo").AsQueryable();
        }

        public IQueryable<SportCountryInfo> GetSportCountryInfo(long? sportcountryid)
        {
            return _dbService.dbContext().SportCountryInfo.FromSqlInterpolated($"EXECUTE dbo.GetSportCountryInfoById {sportcountryid}").AsQueryable();
        }

    }
}
