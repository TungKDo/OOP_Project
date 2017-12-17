using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class Demon : Creature
    {
        public Demon(string cardName, uint manaCost, uint attackPoints, int healthPoints) : base("Demon", 7, 7, 7)
        {

        }

        protected override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
