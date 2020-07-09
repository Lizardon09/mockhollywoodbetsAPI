using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class SportTreeRepository : ISportTreeRepository
    {
        private IDataBase _dbService;

        public SportTreeRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(SportTree entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SportTree entity)
        {
            throw new NotImplementedException();
        }

        public SportTree Get(long id)
        {
            return _dbService.dbContext().SportTree.FromSqlInterpolated($"EXECUTE dbo.GetSportById {id}").AsEnumerable().FirstOrDefault();
        }

        public IQueryable<SportTree> Get(long? sportid)
        {
            return _dbService.dbContext().SportTree.FromSqlInterpolated($"EXECUTE dbo.GetSportById {sportid}").AsQueryable();
        }

        public IQueryable<SportTree> GetAll()
        {
            return _dbService.dbContext().SportTree.FromSqlInterpolated($"EXECUTE dbo.GetAllSports").AsQueryable();
        }

        public void Update(SportTree entity)
        {
            throw new NotImplementedException();
        }
    }
}
