using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class SportCountry2
    {
        public long SportID { get; set; }
        public List<long> CountryID { get; set; }

        public SportCountry2()
        {

        }

        public SportCountry2(long sportid, List<long> countryid)
        {
            this.SportID = sportid;
            this.CountryID = countryid;
        }
    }
}
