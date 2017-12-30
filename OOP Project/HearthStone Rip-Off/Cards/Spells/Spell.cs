using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells
{
    public abstract class Spell : Card, ICard, ISpell
    {
        private int damage;

        public Spell(string cardName, uint manaCost, int damage)
        {
            base.CardName = cardName;
            base.ManaCost = manaCost;
            this.Damage = damage;
        }

        public int Damage
        {
            get
            { return this.damage; }
            protected set
            { this.damage = value; }
        }

        public override bool IsCreature()
        {
            return false;
        }

        public override void ShowInfo()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Name: {0}, Mana cost: {1}, Damage: {2}", this.CardName, this.ManaCost, this.damage);

            Console.WriteLine(str.ToString());
        }
    }
}
