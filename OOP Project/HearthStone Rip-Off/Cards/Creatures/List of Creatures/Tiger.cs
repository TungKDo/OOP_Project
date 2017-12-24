using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class Tiger : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "Tiger";
        private readonly uint manaCost = 5;
        private readonly uint attackPoints = 5;
        private readonly int healthPoints = 5;

        public Tiger()// : base("Tiger", 5, 5, 5)
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
