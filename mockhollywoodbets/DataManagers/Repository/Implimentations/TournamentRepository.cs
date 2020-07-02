using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class TournamentRepository : ITournamentRepository
    {

        private IDataBase _dbService;

        public TournamentRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(Tournament entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tournament entity)
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

        public void Update(Tournament entity)
        {
            throw new NotImplementedException();
        }
    }
}
