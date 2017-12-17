using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class EmperorCobra : Creature
    {
        public EmperorCobra(string cardName, uint manaCost, uint attackPoints, int healthPoints) : base("EmperorCobra", 3, 3, 3)
        {
        }

        protected override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
