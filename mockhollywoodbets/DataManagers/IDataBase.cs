﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBets.Models;

namespace MockHollywoodBets.DataManagers
{
    public interface IDataBase
    {
        MockHollywoodBetsContext dbContext();
    }
}