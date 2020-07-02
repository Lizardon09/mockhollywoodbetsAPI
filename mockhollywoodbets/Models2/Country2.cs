using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class Country2
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Country2()
        {

        }

        public Country2(long id, string name, string logo)
        {
            this.Id = id;
            this.Name = name;
            this.Code = logo;
        }
    }
}
