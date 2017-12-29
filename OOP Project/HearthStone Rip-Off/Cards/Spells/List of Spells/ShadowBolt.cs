using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells.List_of_Spells
{
    public class ShadowBolt : Spell
    {
        public ShadowBolt(string cardName = "ShadowBolt", uint manaCost = 3, uint damage = 4) : base(cardName, manaCost, damage)
        {
        }
    }
}
