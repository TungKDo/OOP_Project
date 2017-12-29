using Bytes2you.Validation;
using HearthStone_Rip_Off.BattleField;
using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HearthStone_Rip_Off
{
    public class Player
    {
        private int lifePoint;
        private int manaCrystals;
        private int maxManaCrystals;
        private Hand playerHand;
        private Deck.Deck playerDeck;
        private IList<ICreature> battleField;

        

        public Player()
        {
            this.lifePoint = 15;
            this.playerHand = new Hand();
            this.playerDeck = new Deck.Deck();
            this.battleField = new List<ICreature>();
            this.ManaCrystals = 0;
            this.MaxManaCrystals = 0;
        }

        public int ManaCrystals
        {
            get
            {
                return manaCrystals;
            }
            set
            {
                this.manaCrystals = value;
            }
        }
        public int MaxManaCrystals
        {
            get
            {
                return maxManaCrystals;
            }
            set
            {
                this.maxManaCrystals = value;
            }
        }
        public Hand PlayerHand
        {
            get
            {
                return this.playerHand;
            }
            protected set
            {
                this.playerHand = value;
            }
        }

        public Deck.Deck PlayerDeck
        {
            get
            {
                return this.playerDeck;
            }
            set
            {
                this.playerDeck = value;
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

        public void DrawACards()
        {
            ICard cardToBeDraw = PlayerDeck.Cards[PlayerDeck.Cards.Count - 1];
            this.PlayerHand.Add(cardToBeDraw);
            this.PlayerDeck.Remove(cardToBeDraw);
        }



    }
}

