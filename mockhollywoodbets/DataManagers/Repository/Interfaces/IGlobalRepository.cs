using MockHollywoodBets.DataManagers.Repository.Implimentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers.Repository.Interfaces
{
    public interface IGlobalRepository
    {
        SportTreeRepository SportTreeRepo { get; set; }
    }
}
