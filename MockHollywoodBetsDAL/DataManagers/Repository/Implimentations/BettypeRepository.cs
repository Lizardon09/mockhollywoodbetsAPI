using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

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
            throw new NotImplementedException();
        }

        public int Delete(Bettype entity)
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

        public int Update(Bettype entity)
        {
            throw new NotImplementedException();
        }
    }
}
