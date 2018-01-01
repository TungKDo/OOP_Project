using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Contracts
{
    interface IPlayer
    {
        int Lifepoints { get; set; }
        int ManaCrystals { get; set; }
        int MaxManaCrystals { get; set; }
    }
}
