using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.Models
{
    public partial class Account
    {
        public Account()
        {
            BetSlip = new HashSet<BetSlip>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccountDetailId { get; set; }

        public virtual AccountDetail AccountDetail { get; set; }
        public virtual ICollection<BetSlip> BetSlip { get; set; }
    }
}
