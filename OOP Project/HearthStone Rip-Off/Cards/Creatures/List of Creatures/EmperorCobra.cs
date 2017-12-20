using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class EmperorCobra : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "EmperorCobra";
        private readonly uint manaCost = 3;
        private readonly uint attackPoints = 3;
        private readonly int healthPoints = 3;

        public EmperorCobra() 
        {
            base.Type = type;
            base.CardName = cardName;
            base.ManaCost = manaCost;
            base.AttackPoints = attackPoints;
            base.HealthPoints = healthPoints;
        }

        protected override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
