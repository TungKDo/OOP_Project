using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells
{
    class Spell : ICard
    {
        private uint damage;
        private uint manaCost;


        public uint ManaCost => 0;
    }
}
