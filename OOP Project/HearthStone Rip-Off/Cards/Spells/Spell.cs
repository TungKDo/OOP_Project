using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells
{
    public abstract class Spell : Card, ISpell
    {
        private uint damage;

        public Spell(string cardName, uint manaCost, uint damage)
        {
            base.CardName = cardName;
            base.ManaCost = manaCost;
            this.Damage = damage;
        }

        public uint Damage
        {
            get
            { return this.damage; }
            protected set
            { this.damage = value; }
        }


    }
}
