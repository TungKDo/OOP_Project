using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Contracts
{
    public interface ICard
    {
        string CardName { get; }
        uint ManaCost { get; }
        void ShowInfo();
        bool IsCreature();
    }
}
