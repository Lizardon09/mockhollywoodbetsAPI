using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Country()
        {

        }

        public Country(long id, string name, string logo)
        {
            this.Id = id;
            this.Name = name;
            this.Code = logo;
        }
    }
}
