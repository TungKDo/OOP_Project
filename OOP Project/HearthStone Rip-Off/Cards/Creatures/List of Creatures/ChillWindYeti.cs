using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class ChillWindYeti : Creature
    {
        public ChillWindYeti(string cardName, uint manaCost, uint attackPoints, int healthPoints) : base("ChillWindYeti", 4, 4, 5)
        {
        }

        protected override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
