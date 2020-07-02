using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.CustomModels;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using MockHollywoodBets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class MarketRepository : IMarketRepository
    {
        private IDataBase _dbService;

        public MarketRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(Market entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Market entity)
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

        public void Update(Market entity)
        {
            throw new NotImplementedException();
        }

    }
}
