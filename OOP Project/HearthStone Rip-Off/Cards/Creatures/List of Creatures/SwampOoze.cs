using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class SwampOoze : Creature
    {
        public SwampOoze(string cardName = "SwampOoze", uint manaCost = 2, uint attackPoints = 3,
            int healthPoints = 2, CreatureType type = CreatureType.Neutral)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
