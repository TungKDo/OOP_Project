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
        private PlayerDeck playerdeck;
        private Hand playerHand;


        public Player(int lifePoint,PlayerDeck deck,Hand playerhand )
        {
            if(deck == null)
            {
                throw new ArgumentNullException(nameof(deck));
            }
            Guard.WhenArgument(lifePoint, "Initial LifePoints must be possitive").IsLessThan(1).Throw();
            this.LifePoints = lifePoint;
            this.PlayerDeck = new PlayerDeck();
            this.PlayerHand = new Hand();
        }

        public PlayerDeck PlayerDeck
        {
            get
            {
                return this.playerdeck;
            }
            set
            {
                this.playerdeck = value;
            }
        }
        public Hand PlayerHand
        {
            get
            {
                return this.playerHand;
            }
            set
            {
                this.playerHand = value;
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
                this.lifePoint = value;
            }
        }

    }
}

