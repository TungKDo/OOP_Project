using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class WaterElemental : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "WaterElemental";
        private readonly uint manaCost = 4;
        private readonly uint attackPoints = 3;
        private readonly int healthPoints = 6;

        public WaterElemental() //: base("WaterElemental", 4, 3, 6)
        {
            base.Type = type;
            base.CardName = cardName;
            base.ManaCost = manaCost;
            base.AttackPoints = attackPoints;
            base.HealthPoints = healthPoints;
        }

        public override string Greeting()
        {
            return "OAgasd";
        }
    }
}
