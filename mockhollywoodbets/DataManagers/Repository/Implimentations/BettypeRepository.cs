using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class BettypeRepository : IBettypeRepository
    {

        private IDataBase _dbService;

        public BettypeRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(Bettype entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bettype entity)
        {
            throw new NotImplementedException();
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

        public void Update(Bettype entity)
        {
            throw new NotImplementedException();
        }
    }
}
