using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells.List_of_Spells
{
    public class FrostBolt : Spell
    {
        public FrostBolt(string cardName = "FrostBolt", uint manaCost = 2, uint damage = 3) : base(cardName, manaCost, damage)
        {
        }
    }
}
