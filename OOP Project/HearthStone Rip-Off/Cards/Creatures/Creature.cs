using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Cards.Creatures
{
    public abstract class Creature : Card, ICard, ICreature
    {
        
        private int attackPoints;
        private int healthPoints;
        private readonly CreatureType type;

        public Creature(string cardName, uint manaCost, int attackPoints, int healthPoints, CreatureType type)
        {
            base.CardName = cardName;
            base.ManaCost = manaCost;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.type = type;
        }
        
        public int AttackPoints
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
            set
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
        }

        public override bool IsCreature()
        {
            return true;
        }

        public override void ShowInfo()
        {
            StringBuilder str = new StringBuilder();
            
            str.AppendFormat("Name: {0}, Mana cost: {1}, Attack points: {2}, Health points: {3}, Creature type:{4}", 
                base.CardName, base.ManaCost, this.attackPoints, this.healthPoints, this.type);

            Console.WriteLine(str.ToString());
        }
    }
}
