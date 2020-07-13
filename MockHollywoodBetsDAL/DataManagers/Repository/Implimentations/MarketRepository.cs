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
            throw new NotImplementedException();
        }

        public int Delete(Market entity)
        {
            throw new NotImplementedException();
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

        public int Update(Market entity)
        {
            throw new NotImplementedException();
        }

    }
}
