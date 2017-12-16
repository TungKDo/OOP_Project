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
        private uint manaCost;
        private uint attackPoints;
        private int healthPoints;

        public Creature(uint manaCost, uint attackPoints, int healthPoints )
        {

            
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

        public uint AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
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
            private set
            {
                this.healthPoints = value;
            }

        }

        protected abstract string Greeting();

    }
}
