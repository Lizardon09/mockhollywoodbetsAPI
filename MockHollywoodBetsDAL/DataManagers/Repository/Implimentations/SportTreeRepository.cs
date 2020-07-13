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
    public class SportTreeRepository : ISportTreeRepository
    {
        private IDataBase _dbService;

        public SportTreeRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(SportTree entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertSportTree {entity.Name},{entity.Logo}");
                return result;
            }
        }

        public int Update(SportTree entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateSportTree {entity.Id},{entity.Name},{entity.Logo}");
                return result;
            }
        }

        public int Delete(SportTree entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteSportTree {entity.Id}");
                return result;
            }
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

        /*
         * 
         * 1. using gets sql connection from db service to use
         * 2. result Query mainly used for get operations
         * 3. result2 Execute used for CRUD which will return number of rows effected by statement executed
         * 4. can use stored proc notation for both Query and Execute
         * 
        using (var connection = DBService.GetSqlConnection())
        {
            var result = connection.Query<SportTree>("SELECT * FROM dbo.SportTree").AsQueryable();
            var result = connection.Query<SportTree>($"EXECUTE dbo.GetAllSports").AsQueryable();
            var result2 = connection.Execute("");
            return result2 > 0;
            return result;
        }*/
    }
}
