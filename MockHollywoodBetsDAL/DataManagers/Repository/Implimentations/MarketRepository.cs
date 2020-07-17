using Dapper;
using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                return result + 1;
            }
        }

        public int Update(Market entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateMarket {entity.Id},{entity.Name}");
                return result + 1;
            }
        }

        public int Delete(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteMarket {id}");
                return result + 1;
            }
        }

        public int AddMarketBettype(MarketBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertMarketBettype {entity.MarketId},{entity.BettypeId}");
                return result + 1;
            }
        }

        public int UpdateMarketBettype(MarketBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateMarketBettype {entity.Id},{entity.MarketId},{entity.BettypeId}");
                return result + 1;
            }
        }

        public int UpdateOdd(Odds entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {

                var parameters = new { entity.Id, entity.MarketBettypeId, entity.EventId, entity.Odds1 };
                connection.Execute("dbo.UpdateOdd", parameters, commandType: CommandType.StoredProcedure);
                return 0;

            }
        }

        public int DeleteOdd(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteOdd {id}");
                return result + 1;
            }
        }

        public int DeleteMarketBettype(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteMarketBettype {id}");
                return result + 1;
            }
        }

        public int AddOdd(Odds entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                            
                var parameters = new { entity.MarketBettypeId, entity.EventId, entity.Odds1 };
                connection.Execute("dbo.InsertOdd", parameters, commandType: CommandType.StoredProcedure);
                return 0;

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

        public IQueryable<Market> GetMarket(long? marketid)
        {
            return _dbService.dbContext().Market.FromSqlInterpolated($"EXECUTE dbo.GetMarketByMarketId {marketid}").AsQueryable();
        }

        public IQueryable<Market> GetMarkets()
        {
            return _dbService.dbContext().Market.FromSqlInterpolated($"EXECUTE dbo.GetMarkets").AsQueryable();
        }

        public IQueryable<MarketBettypeInfo> GetAllMarketBettypeInfo()
        {
            return _dbService.dbContext().MarketBettypeInfo.FromSqlInterpolated($"EXECUTE dbo.GetAllMarketBettypeInfo").AsQueryable();
        }

        public IQueryable<MarketBettypeInfo> GetMarketBettypeInfo(long? marketbettypeid)
        {
            return _dbService.dbContext().MarketBettypeInfo.FromSqlInterpolated($"EXECUTE dbo.GetMarketBettypeInfoByMarketBettypeId {marketbettypeid}").AsQueryable();
        }

        public IQueryable<OddInfo> GetAllOddInfo()
        {
            return _dbService.dbContext().OddInfo.FromSqlInterpolated($"EXECUTE dbo.GetAllOddInfo").AsQueryable();
        }

        public IQueryable<OddInfo> GetOddInfo(long? oddid)
        {
            return _dbService.dbContext().OddInfo.FromSqlInterpolated($"EXECUTE dbo.GetOddInfoById {oddid}").AsQueryable();
        }
    }
}
