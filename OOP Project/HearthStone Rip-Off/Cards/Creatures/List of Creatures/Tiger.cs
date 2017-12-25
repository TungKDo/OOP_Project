using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class Tiger : Creature
    {
        public Tiger(string cardName = "Tiger", uint manaCost = 5, uint attackPoints = 5,
            int healthPoints = 5, CreatureType type = CreatureType.Beast)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
