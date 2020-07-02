using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockHollywoodBets.Models2
{
    public class Bettype2
    {
        public long BettypeID { get; set; }
        public string BettypeName { get; set; }

        public Bettype2()
        {

        }

        public Bettype2(long id, string name)
        {
            this.BettypeID = id;
            this.BettypeName = name;
        }

    }
}
