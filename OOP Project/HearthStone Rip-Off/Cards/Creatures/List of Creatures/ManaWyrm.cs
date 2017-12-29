using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class ManaWyrm : Creature
    {
        public ManaWyrm() 
            : base("ManaWyrm", 1, 1, 3, CreatureType.Neutral)
        {
        }
    }
}