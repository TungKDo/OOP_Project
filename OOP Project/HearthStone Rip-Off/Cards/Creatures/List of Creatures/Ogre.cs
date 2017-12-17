using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    class Ogre : Creature
    {
        public Ogre(string cardName, uint manaCost, uint attackPoints, int healthPoints) : base("Ogre", 6, 6, 7)
        {
        }

        protected override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
