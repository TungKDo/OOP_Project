using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class ManaWyrm : Creature
    {
        public ManaWyrm(string cardName = "ManaWyrm", uint manaCost = 1, uint attackPoints = 1,
            int healthPoints = 3, CreatureType type = CreatureType.Neutral) 
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
