using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models
{
    public class Bettype
    {
        public long BettypeID { get; set; }
        public string BettypeName { get; set; }

        public Bettype()
        {

        }

        public Bettype(long id, string name)
        {
            this.BettypeID = id;
            this.BettypeName = name;
        }

    }
}
