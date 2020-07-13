using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Interfaces
{
    public interface IDataRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(long id);
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
