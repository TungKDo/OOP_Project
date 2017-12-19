using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class ChillWindYeti : Creature
    {

        public ChillWindYeti(string cardName = "ChillWindYeti", uint manaCost = 4, uint attackPoints = 4, int healthPoints = 5, CreatureType type) : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }

        protected override string Greeting()
        {
            return "asdfasd";
        }
    }
}
