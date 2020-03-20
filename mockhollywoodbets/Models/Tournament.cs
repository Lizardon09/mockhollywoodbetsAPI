using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class Tournament
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Countrycode { get; set; }
        public long Sportcode { get; set; }

        public Tournament(long id, string name, long countrycode, long sportcode)
        {
            this.Id = id;
            this.Name = name;
            this.Countrycode = countrycode;
            this.Sportcode = sportcode;
        }

    }
}
