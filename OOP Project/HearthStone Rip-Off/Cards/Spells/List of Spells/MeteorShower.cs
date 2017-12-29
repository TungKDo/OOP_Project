using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells.List_of_Spells
{
    public class MeteorShower : Spell
    {
        public MeteorShower(string cardName = "MeteorShower", uint manaCost = 5, uint damage = 6) : base(cardName, manaCost, damage)
        {
        }
    }
}
