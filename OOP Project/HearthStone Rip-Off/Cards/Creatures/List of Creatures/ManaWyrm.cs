using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class ManaWyrm : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "ManaWyrm";
        private readonly uint manaCost = 1;
        private readonly uint attackPoints = 1;
        private readonly int healthPoints = 3;

        public ManaWyrm() //: base("Manawyrm", 1, 1, 3)
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
