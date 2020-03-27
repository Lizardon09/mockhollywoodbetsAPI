using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class DAL
    {
        public List<Country> Countries { get; set; }
        public List<SportTree> Sports { get; set; }
        public List<Tournament> Tournaments { get; set; }
        public List<TournamentSC> Tournamentassociations { get; set; }
        public List<SportCountry> SportCountries { get; set; }
        public List<Bettype> Bettypes { get; set; }
        public List<TournamentBettype> TournamentBettypes {get; set;}
        public List<Event> Events { get; set; }

        public DAL()
        {
            Countries = new List<Country>()
            {

                new Country(1, "Gambia", "GM"),
                new Country(2, "Mauritania", "MR"),
                new Country(3, "Qatar", "QA"),
                new Country(4, "Afghanistan", "AF"),
                new Country(5, "Andorra", "AD"),
                new Country(6, "Angola", "AO"),
                new Country(7, "Antigua and Barbuda", "AG"),
                new Country(8, "Argentina", "AR"),
                new Country(9, "Armenia", "AM"),
                new Country(10, "Australia", "AU"),
                new Country(11, "Austria", "AT"),
                new Country(12, "Azerbaijan", "AZ"),
                new Country(13, "Bahamas", "BS"),
                new Country(14, "Bahrain", "BH"),
                new Country(15, "Albania", "AL")

            };

            SportCountries = new List<SportCountry>()
            {
                new SportCountry(1, new List<long>(){ 4 }),
                new SportCountry(2, new List<long>(){ 1, 2, 3, 4, 5, 11, 12, 13, 14, 15}),
                new SportCountry(4, new List<long>(){ 1, 2, 3 }),
                new SportCountry(5, new List<long>(){ 1, 2, 3, 10, 7 }),
                new SportCountry(7, new List<long>(){ 5, 9, 12 })

            };

            Sports = new List<SportTree>()
            {
                new SportTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportTree(2, "Live In-Play", "https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportTree(3, "Sport Exotics", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree(4, "Horse Racing", "https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportTree(5, "Soccer", "https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportTree(6, "Lucky Numbers", "https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportTree(7, "Rugby", "https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportTree(8, "Cricket", "https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportTree(9, "Golf", "https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportTree(10, "Aussie Rules", "https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportTree(11, "Bandy", "https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportTree(12, "BasketBall", "https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportTree(13, "Bowls", "https://new.hollywoodbets.net/assets/images/icons/bowls.svg"),
                new SportTree(14, "Boxing", "https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportTree(15, "Darts", "https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportTree(16, "Futsal", "https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportTree(17, "Ice Hockey", "https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportTree(18, "MMA", "https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportTree(19, "Motorsport", "https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportTree(20, "Table Tennis", "https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportTree(21, "Vollyball", "https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };

            Tournaments = new List<Tournament>()
            {
                new Tournament(1, "Gambia Division 2"),
                new Tournament(2, "Mauritinia Division 2"),
                new Tournament(3, "Qatar Qatar Cup")
            };

            Tournamentassociations = new List<TournamentSC>()
            {
                new TournamentSC(1, 5, new List<long>(){ 1 }),
                new TournamentSC(2, 5, new List<long>(){ 2, 3})
            };

            Events = new List<Event>()
            {
                new Event(1, 1, "Burger vs cheesys", new DateTime(2020, 3, 26, 10, 30, 0)),
                new Event(1, 2, "Nados vs McDonalds", new DateTime(2020, 3, 26, 17, 30, 0)),
                new Event(1, 3, "Fries vs chicken", new DateTime(2020, 3, 26, 12, 0, 0)),
                new Event(2, 4, "Sharks vs Whales", new DateTime(2020, 3, 26, 8, 15, 0)),
                new Event(2, 5, "Dolphin vs Sharks", new DateTime(2020, 3, 26, 9, 45, 0)),
                new Event(3, 6, "Dallas vs Texasmen", new DateTime(2020, 3, 26, 7, 20, 0))
            };

            Bettypes = new List<Bettype>()
            {
                new Bettype(1, "Full Time"),
                new Bettype(2, "Double Chance"),
                new Bettype(3, "Both Teams to Score"),
                new Bettype(4, "Double Chance and Both Teams to Score")
            };

            TournamentBettypes = new List<TournamentBettype>()
            {
                new TournamentBettype(1, new List<long>(){ 1, 2 }),
                new TournamentBettype(2, new List<long>(){ 1,3,4}),
                new TournamentBettype(3, new List<long>(){ 2, 4})
            };

    }

        public List<Country> GetCountryByID(List<long> countryids)
        {
            List<Country> countries = new List<Country>();

            for (int i = 0; i < countryids.Count; i++)
            {
                countries.Add(Countries.Find(country => country.Id == countryids[i]));
            }

            return countries;
        }

        public List<Tournament> GetTournamentsByCountrySport(long? countryid, long? sportid)
        {
            TournamentSC temp = this.Tournamentassociations.Find(association => association.Countrycode == countryid && association.Sportcode == sportid);
            List<Tournament> tournaments = new List<Tournament>();

            if (temp!=null)
            {
                for (int i = 0; i < temp.Tournamentcodes.Count; i++)
                {
                    tournaments.Add(this.Tournaments.Find(tournament => tournament.Id == temp.Tournamentcodes[i]));
                }
            }

            return tournaments;

        }

        public List<Bettype> GetBettypeByTournament(long? tournamentid)
        {
            TournamentBettype temp = this.TournamentBettypes.Find(association => association.TournamentID == tournamentid);
            List<Bettype> bettypes = new List<Bettype>();

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
