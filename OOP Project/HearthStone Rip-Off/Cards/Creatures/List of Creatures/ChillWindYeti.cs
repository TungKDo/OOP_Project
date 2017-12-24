using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class ChillWindYeti : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "ChillWindYeti";
        private readonly uint manaCost = 4;
        private readonly uint attackPoints = 4;
        private readonly int healthPoints = 5;

        public ChillWindYeti()
        {
            base.Type = type;
            base.CardName = cardName;
            base.ManaCost = manaCost;
            base.AttackPoints = attackPoints;
            base.HealthPoints = healthPoints;
        }

        public override string Greeting()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.Greeting());

            //TODO append greeting of the creature

            return str.ToString();
        }
    }
}
