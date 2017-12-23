using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public class Creature : Card, ICard, ICreature
    {
        private uint attackPoints;
        private int healthPoints;
        private CreatureType type;
        
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

        public override string Greeting()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Name: {0}, Mana cost: {1}, Attack points: {2}, Health points: {3}", 
                base.CardName, base.ManaCost, this.attackPoints, this.healthPoints);

            return str.ToString();
        }

    }
}
