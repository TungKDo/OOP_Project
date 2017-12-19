using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells.List_of_Spells
{
    class LightningBolt : Spell
    {
        public LightningBolt(string cardName = "LightningBolt", uint manaCost = 6, uint damage = 7) : base(cardName, manaCost, damage)
        {
        }
    }
}
