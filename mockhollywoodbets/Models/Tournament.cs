using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class Tournament
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Tournament(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
