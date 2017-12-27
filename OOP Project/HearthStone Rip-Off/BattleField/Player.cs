using Bytes2you.Validation;
using HearthStone_Rip_Off.BattleField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerDeck = HearthStone_Rip_Off.Deck.Deck;

namespace HearthStone_Rip_Off
{
    public class Player
    {
        private int lifePoint;
        private Hand playerHand;


        
        public Player(int lifePoint,PlayerDeck deck,Hand playerhand )
        {

            this.LifePoints = lifePoint;
            this.playerHand = new Hand();
        }
        
        public Hand PlayerHand
        {
            get
            {
                return this.playerHand;
            }
        }

        public int LifePoints
        {
            get
            {
                return this.lifePoint;
            }
            set
            {
                if(value < 1)
                    Console.WriteLine("Life points must be more than 1.");

                this.lifePoint = value;
            }
        }

    }
}

