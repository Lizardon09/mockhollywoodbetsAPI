using MockHollywoodBets.DataManagers.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Implimentations
{
    public class GlobalRepository : IGlobalRepository
    {
        public SportTreeRepository SportTreeRepo { get; set; }

        public GlobalRepository(
                SportTreeRepository sportTreeRepository
            )
        {
            SportTreeRepo = sportTreeRepository;
        }

    }
}
