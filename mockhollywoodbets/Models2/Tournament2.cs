using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class Tournament2
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Tournament2(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
