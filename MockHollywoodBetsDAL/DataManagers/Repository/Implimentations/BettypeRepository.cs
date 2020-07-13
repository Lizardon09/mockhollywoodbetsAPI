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
                return result;
            }
        }

        public int Update(Bettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateBettype {entity.Id},{entity.Name}");
                return result;
            }
        }

        public int Delete(Bettype entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteBettype {entity.Id}");
                return result;
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
