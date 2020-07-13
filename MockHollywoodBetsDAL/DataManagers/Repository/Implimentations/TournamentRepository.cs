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
    public class TournamentRepository : ITournamentRepository
    {

        private IDataBase _dbService;

        public TournamentRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Tournament entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertTournament {entity.Name}");
                return result;
            }
        }

        public int Update(Tournament entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateTournament {entity.Id},{entity.Name}");
                return result;
            }
        }

        public int Delete(Tournament entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteTournament {entity.Id}");
                return result;
            }
        }

        public Tournament Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tournament> Get(long? sportid, long? countryid)
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetTournamentBySC {sportid},{countryid}").AsQueryable();
        }

        public IQueryable<Tournament> GetAll()
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetAllTournaments").AsQueryable();
        }

        public IQueryable<Tournament> GetTournament(long? tournamentid)
        {
            return _dbService.dbContext().Tournament.FromSqlInterpolated($"EXECUTE dbo.GetTournamentByTournamentId {tournamentid}").AsQueryable();
        }
    }
}
