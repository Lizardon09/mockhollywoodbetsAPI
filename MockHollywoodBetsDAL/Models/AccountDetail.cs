using System;
using System.Collections.Generic;
using System.Text;

namespace MockHollywoodBetsDAL.Models
{
    public partial class AccountDetail
    {
        public AccountDetail()
        {
            Account = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int? ContactNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}
