using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class SportCountry
    {
        public long SportID { get; set; }
        public List<long> CountryID { get; set; }

        public SportCountry()
        {

        }

        public SportCountry(long sportid, List<long> countryid)
        {
            this.SportID = sportid;
            this.CountryID = countryid;
        }
    }
}
