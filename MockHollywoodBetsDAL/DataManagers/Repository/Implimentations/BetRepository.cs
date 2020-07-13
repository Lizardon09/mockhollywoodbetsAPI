using Dapper;
using MockHollywoodBetsDAL.CustomModels;
using MockHollywoodBetsDAL.DataManagers.Repository.Interfaces;
using MockHollywoodBetsDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MockHollywoodBetsDAL.DataManagers.Repository.Implimentations
{
    public class BetRepository : IBetRepository
    {
        private IDataBase _dbService;

        public BetRepository(IDataBase dbService)
        {
            _dbService = dbService;
        }

        public int Add(BetSlipInfo entity)
        {
            using (var connection = DBService.GetSqlConnection())
            {
                var parameters = new { entity.BetSlip.TotalStake, entity.BetSlip.TotalPayout, entity.BetSlip.FinalOdds, entity.BetSlip.AccountId };

                connection.Execute("dbo.InsertBetSlip", parameters, commandType:CommandType.StoredProcedure);

                var result = 1;

                var betslipid = connection.Query<BetSlip>("dbo.GetLatestBetSlipId", commandType: CommandType.StoredProcedure).First();

                for (int i=0; i<entity.Bets.Count(); i++)
                {
                    var parameters2 = new { betslipid.Id, entity.Bets[i].MarketId, entity.Bets[i].SportId, entity.Bets[i].Odds, entity.Bets[i].TournamentId, entity.Bets[i].Date, entity.Bets[i].EventId, entity.Bets[i].BettypeId, entity.Bets[i].Stake, entity.Bets[i].Payout };
                    connection.Execute("dbo.InsertBet", parameters2, commandType: CommandType.StoredProcedure);
                    result += 1;
                }

                return result;

            }
        }

        public int Delete(BetSlipInfo entity)
        {
            throw new NotImplementedException();
        }

        public BetSlipInfo Get(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BetSlipInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(BetSlipInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
