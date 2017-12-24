using System;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public class Ogre : Creature, ICard
    {
        private readonly CreatureType type = CreatureType.Beast;
        private readonly string cardName = "Ogre";
        private readonly uint manaCost = 6;
        private readonly uint attackPoints = 6;
        private readonly int healthPoints = 7;

        public Ogre() // : base("Ogre", 6, 6, 7)
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
