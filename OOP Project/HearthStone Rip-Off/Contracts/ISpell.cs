﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Contracts
{
    public interface ISpell : ICard
    {
        int Damage { get; }
    }
}
