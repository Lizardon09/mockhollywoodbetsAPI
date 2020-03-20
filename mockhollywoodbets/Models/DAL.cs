using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class DAL
    {
        public List<Country> Countries { get; set; }
        public List<SportTree> Sports { get; set; }
        public List<KeyValuePair<long, long>> SportCountryAssoc { get; set; }

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

            SportCountryAssoc = new List<KeyValuePair<long, long>>()
            {
                new KeyValuePair<long, long>(4, 1),
                new KeyValuePair<long, long>(4, 2),
                new KeyValuePair<long, long>(4, 3),

                new KeyValuePair<long, long>(5, 3),
                new KeyValuePair<long, long>(5, 10),
                new KeyValuePair<long, long>(5, 7),

                new KeyValuePair<long, long>(7, 5),
                new KeyValuePair<long, long>(7, 9),
                new KeyValuePair<long, long>(7, 12)
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

        }

        public Country GetCountryByID(long id)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].Id == id)
                    return Countries[i];
            }

            return new Country();
        }

    }
}
