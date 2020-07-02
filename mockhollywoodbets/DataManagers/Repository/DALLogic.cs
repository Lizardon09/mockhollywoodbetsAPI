using MockHollywoodBets.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.DataManagers
{
    public class DALLogic
    {
        public List<Country2> Countries { get; set; }
        public List<SportTree2> Sports { get; set; }
        public List<Tournament2> Tournaments { get; set; }
        public List<TournamentSC2> Tournamentassociations { get; set; }
        public List<SportCountry2> SportCountries { get; set; }
        public List<Bettype2> Bettypes { get; set; }
        public List<TournamentBettype2> TournamentBettypes {get; set;}
        public List<Event2> Events { get; set; }

        public DALLogic()
        {
            Countries = new List<Country2>()
            {

                new Country2(1, "Gambia", "GM"),
                new Country2(2, "Mauritania", "MR"),
                new Country2(3, "Qatar", "QA"),
                new Country2(4, "Afghanistan", "AF"),
                new Country2(5, "Andorra", "AD"),
                new Country2(6, "Angola", "AO"),
                new Country2(7, "Antigua and Barbuda", "AG"),
                new Country2(8, "Argentina", "AR"),
                new Country2(9, "Armenia", "AM"),
                new Country2(10, "Australia", "AU"),
                new Country2(11, "Austria", "AT"),
                new Country2(12, "Azerbaijan", "AZ"),
                new Country2(13, "Bahamas", "BS"),
                new Country2(14, "Bahrain", "BH"),
                new Country2(15, "Albania", "AL")

            };

            SportCountries = new List<SportCountry2>()
            {
                new SportCountry2(1, new List<long>(){ 4 }),
                new SportCountry2(2, new List<long>(){ 1, 2, 3, 4, 5, 11, 12, 13, 14, 15}),
                new SportCountry2(4, new List<long>(){ 1, 2, 3 }),
                new SportCountry2(5, new List<long>(){ 1, 2, 3, 10, 7 }),
                new SportCountry2(7, new List<long>(){ 5, 9, 12 })

            };

            Sports = new List<SportTree2>()
            {
                new SportTree2(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportTree2(2, "Live In-Play", "https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportTree2(3, "Sport Exotics", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree2(4, "Horse Racing", "https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportTree2(5, "Soccer", "https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportTree2(6, "Lucky Numbers", "https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportTree2(7, "Rugby", "https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportTree2(8, "Cricket", "https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportTree2(9, "Golf", "https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportTree2(10, "Aussie Rules", "https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportTree2(11, "Bandy", "https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportTree2(12, "BasketBall", "https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportTree2(13, "Bowls", "https://new.hollywoodbets.net/assets/images/icons/bowls.svg"),
                new SportTree2(14, "Boxing", "https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportTree2(15, "Darts", "https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportTree2(16, "Futsal", "https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportTree2(17, "Ice Hockey", "https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportTree2(18, "MMA", "https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportTree2(19, "Motorsport", "https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportTree2(20, "Table Tennis", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree2(21, "Vollyball", "https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };

            Tournaments = new List<Tournament2>()
            {
                new Tournament2(1, "Gambia Division 2"),
                new Tournament2(2, "Mauritinia Division 2"),
                new Tournament2(3, "Qatar Qatar Cup")
            };

            Tournamentassociations = new List<TournamentSC2>()
            {
                new TournamentSC2(1, 5, new List<long>(){ 1 }),
                new TournamentSC2(2, 5, new List<long>(){ 2, 3})
            };

            Events = new List<Event2>()
            {
                new Event2(1, 1, "Burger vs cheesys", new DateTime(2020, 3, 26, 10, 30, 0)),
                new Event2(1, 2, "Nados vs McDonalds", new DateTime(2020, 3, 26, 17, 30, 0)),
                new Event2(1, 3, "Fries vs chicken", new DateTime(2020, 3, 26, 12, 0, 0)),
                new Event2(2, 4, "Sharks vs Whales", new DateTime(2020, 3, 26, 8, 15, 0)),
                new Event2(2, 5, "Dolphin vs Sharks", new DateTime(2020, 3, 26, 9, 45, 0)),
                new Event2(3, 6, "Dallas vs Texasmen", new DateTime(2020, 3, 26, 7, 20, 0))
            };

            Bettypes = new List<Bettype2>()
            {
                new Bettype2(1, "Full Time"),
                new Bettype2(2, "Double Chance"),
                new Bettype2(3, "Both Teams to Score"),
                new Bettype2(4, "Double Chance and Both Teams to Score")
            };

            TournamentBettypes = new List<TournamentBettype2>()
            {
                new TournamentBettype2(1, new List<long>(){ 1, 2 }),
                new TournamentBettype2(2, new List<long>(){ 1,3,4}),
                new TournamentBettype2(3, new List<long>(){ 2, 4})
            };

    }

        public List<Country2> GetCountryByID(List<long> countryids)
        {
            List<Country2> countries = new List<Country2>();

            for (int i = 0; i < countryids.Count; i++)
            {
                countries.Add(Countries.Find(country => country.Id == countryids[i]));
            }

            return countries;
        }

        public List<Tournament2> GetTournamentsByCountrySport(long? countryid, long? sportid)
        {
            TournamentSC2 temp = this.Tournamentassociations.Find(association => association.Countrycode == countryid && association.Sportcode == sportid);
            List<Tournament2> tournaments = new List<Tournament2>();

            if (temp!=null)
            {
                for (int i = 0; i < temp.Tournamentcodes.Count; i++)
                {
                    tournaments.Add(this.Tournaments.Find(tournament => tournament.Id == temp.Tournamentcodes[i]));
                }
            }

            return tournaments;

        }

        public List<Bettype2> GetBettypeByTournament(long? tournamentid)
        {
            TournamentBettype2 temp = this.TournamentBettypes.Find(association => association.TournamentID == tournamentid);
            List<Bettype2> bettypes = new List<Bettype2>();

            if (temp != null)
            {
                for(int i=0; i < temp.BettypeID.Count; i++)
                {
                    bettypes.Add(this.Bettypes.Find(bettype => bettype.BettypeID == temp.BettypeID[i]));
                }
            }

            return bettypes;

        }

    }
}
