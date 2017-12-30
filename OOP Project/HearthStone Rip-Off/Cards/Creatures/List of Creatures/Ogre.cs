using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public class Ogre : Creature
    {
        public Ogre()
            : base("Ogre", 6, 6, 7, CreatureType.Neutral)
        {
        }
    }
}
