using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Spells
{
    public abstract class Spell : ICard, ISpell
    {
        private string cardName;
        private uint damage;
        private uint manaCost;

        public Spell(string cardName, uint manaCost, uint damage )
        {
            this.CardName = cardName;
            this.ManaCost = manaCost;
            this.Damage = damage;
        }
        
        public string CardName
        {
            get
            {
                return this.cardName;
            }
            private set
            {
                this.cardName = value;
            }

        }
        public uint ManaCost
        {
            get
            {
                return this.manaCost;
            }
            private set
            {
                this.manaCost = value;
            }

        }
        public uint Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                this.damage = value;
            }

        }
        
    }
}
