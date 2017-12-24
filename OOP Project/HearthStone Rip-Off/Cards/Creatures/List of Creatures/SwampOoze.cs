using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class SwampOoze : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "SwampOoze";
        private readonly uint manaCost = 2;
        private readonly uint attackPoints = 3;
        private readonly int healthPoints = 2;

        public SwampOoze()// : base("SwampOoze", 2, 3, 2)
        {
            base.Type = type;
            base.CardName = cardName;
            base.ManaCost = manaCost;
            base.AttackPoints = attackPoints;
            base.HealthPoints = healthPoints;
        }

        public override string Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
