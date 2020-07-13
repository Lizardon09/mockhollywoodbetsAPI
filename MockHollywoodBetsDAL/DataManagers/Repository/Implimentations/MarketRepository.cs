using Dapper;
using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Implimentations
{
    public class MarketRepository : IMarketRepository
    {
        private IDataBase _dbService;

        public MarketRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Market entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertMarket {entity.Name}");
                return result;
            }
        }

        public int Update(Market entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateMarket {entity.Id},{entity.Name}");
                return result;
            }
        }

        public int Delete(Market entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteMarket {entity.Id}");
                return result;
            }
        }

        IQueryable<MarketOdd> IMarketRepository.GetAll()
        {
            return _dbService.dbContext().MarketOdd.FromSqlInterpolated($"EXECUTE dbo.GetAllMarkets").AsQueryable();
        }

        public IQueryable<MarketOdd> Get(long? tournamentid)
        {
            return _dbService.dbContext().MarketOdd.FromSqlInterpolated($"EXECUTE dbo.GetMarketsByTournament {tournamentid}").AsQueryable();
        }

        public Market Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Market> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<MarketOdd> GetMarket(long? marketid)
        {
            return _dbService.dbContext().MarketOdd.FromSqlInterpolated($"EXECUTE dbo.GetMarketByMarketId {marketid}").AsQueryable();
        }
    }
}
