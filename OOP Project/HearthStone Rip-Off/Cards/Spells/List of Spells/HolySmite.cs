using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells.List_of_Spells
{
    public class HolySmite : Spell
    {
        public HolySmite(string cardName = "HolySmite", uint manaCost = 1, uint damage = 2) : base(cardName, manaCost, damage)
        {
        }
    }
}
