using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public class Ogre : Creature
    {
        public Ogre(string cardName = "Ogre", uint manaCost = 6, uint attackPoints = 6,
            int healthPoints = 7, CreatureType type = CreatureType.Neutral)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
