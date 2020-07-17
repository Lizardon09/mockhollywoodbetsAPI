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
    public class BettypeRepository : IBettypeRepository
    {

        private IDataBase _dbService;

        public BettypeRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Bettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertBettype {entity.Name}");
                return result + 1;
            }
        }

        public int Update(Bettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateBettype {entity.Id},{entity.Name}");
                return result + 1;
            }
        }

        public int Delete(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteBettype {id}");
                return result + 1;
            }
        }

        public int AddTournamentBettype(TournamentBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertTournamentBettype {entity.TournamentId},{entity.BettypeId}");
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

        public int UpdateTournamentBettype(TournamentBettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateTournamentBettype {entity.Id},{entity.TournamentId},{entity.BettypeId}");
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

        public int DeleteTournamentBettype(long? id)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteTournamentBettype {id}");
                return result + 1;
            }
        }

        public IQueryable<Bettype> Get(long? tournamentid)
        {
            return _dbService.dbContext().Bettype.FromSqlInterpolated($"EXECUTE dbo.GetBettypesByTournament {tournamentid}").AsQueryable();
        }

        public Bettype Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Bettype> GetAll()
        {
            return _dbService.dbContext().Bettype.FromSqlInterpolated($"EXECUTE dbo.GetAllBettypes").AsQueryable();
        }

        public IQueryable<Bettype> GetBettype(long? bettypeid)
        {
            return _dbService.dbContext().Bettype.FromSqlInterpolated($"EXECUTE dbo.GetBettypeByBettypeId {bettypeid}").AsQueryable();
        }
    }
}
