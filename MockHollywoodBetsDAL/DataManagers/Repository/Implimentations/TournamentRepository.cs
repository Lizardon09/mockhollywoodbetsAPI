using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

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
            throw new NotImplementedException();
        }

        public int Delete(Tournament entity)
        {
            throw new NotImplementedException();
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

        public int Update(Tournament entity)
        {
            throw new NotImplementedException();
        }
    }
}
