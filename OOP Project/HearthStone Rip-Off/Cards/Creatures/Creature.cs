using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public abstract class Creature : ICard, ICreature
    {
        private string cardName;
        private uint manaCost;
        private uint attackPoints;
        private int healthPoints;
        private CreatureType type;

        //string cardName,uint manaCost, uint attackPoints, int healthPoints, CreatureType type = CreatureType.Neutral
        public Creature()
        {
            this.Type = type;
            this.CardName = cardName;
            this.ManaCost = manaCost;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
        }

        public uint ManaCost
        {
            get
            {
                return this.manaCost;
            }
            protected set
            {
                this.manaCost = value;
            }

        }

        public uint AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                this.attackPoints = value;
            }

        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            protected set
            {
                this.healthPoints = value;
            }

        }

        public string CardName
        {
            get
            {
                return this.cardName;
            }
            protected set
            {
                this.cardName = value;
            }

        }

        public CreatureType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        protected abstract string Greeting();

    }
}
