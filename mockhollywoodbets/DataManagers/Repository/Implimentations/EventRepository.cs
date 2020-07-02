using Microsoft.EntityFrameworkCore;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class EventRepository : IEventRepository
    {

        private IDataBase _dbService;

        public EventRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public void Add(Event entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Event entity)
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

        public void Update(Event entity)
        {
            throw new NotImplementedException();
        }

    }
}
