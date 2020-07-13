using Microsoft.EntityFrameworkCore;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Implimentations
{
    public class EventRepository : IEventRepository
    {

        private IDataBase _dbService;

        public EventRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Event entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Event entity)
        {
            throw new NotImplementedException();
        }

        public Event Get(long id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Event> IEventRepository.Get(long? tournamentid)
        {
            return _dbService.dbContext().Event.FromSqlInterpolated($"EXECUTE dbo.GetEventsByTournament {tournamentid}").AsQueryable();
        }

        public IQueryable<Event> GetAll()
        {
            return _dbService.dbContext().Event.FromSqlInterpolated($"EXECUTE dbo.GetAllEvents").AsQueryable();
        }

        public int Update(Event entity)
        {
            throw new NotImplementedException();
        }

    }
}
