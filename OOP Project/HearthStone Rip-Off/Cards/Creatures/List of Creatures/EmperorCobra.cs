using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class EmperorCobra : Creature, ICard
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

        public override string Greeting()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.Greeting());

            //TODO append greeting of the creature

            return str.ToString();
        }
    }
}
