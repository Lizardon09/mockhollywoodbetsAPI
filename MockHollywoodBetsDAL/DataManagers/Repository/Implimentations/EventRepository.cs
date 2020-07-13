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
    public class EventRepository : IEventRepository
    {

        private IDataBase _dbService;

        public EventRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(Event entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.InsertEvent {entity.Name},{entity.Date},{entity.TournamentId}");
                return result;
            }
        }

        public int Update(Event entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.UpdateEvent {entity.Id},{entity.Name},{entity.Date},{entity.TournamentId}");
                return result;
            }
        }

        public int Delete(Event entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var result = connection.Execute($"EXECUTE dbo.DeleteEvent {entity.Id}");
                return result;
            }
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

        public IQueryable<Event> GetEvent(long? eventid)
        {
            return _dbService.dbContext().Event.FromSqlInterpolated($"EXECUTE dbo.GetEventByEventId {eventid}").AsQueryable();
        }
    }
}
