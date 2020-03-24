using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class SportCountry
    {
        public long SportID { get; set; }
        public long CountryID { get; set; }

        public SportCountry()
        {

        }

        public SportCountry(long sportid, long countryid)
        {
            this.SportID = sportid;
            this.CountryID = countryid;
        }
    }
}
