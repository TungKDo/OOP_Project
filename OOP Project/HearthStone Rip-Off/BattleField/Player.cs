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
    public class Player : IPlayer
    {
        private int lifepoints;
        private int manaCrystals;
        private int maxManaCrystals;
        private Hand playerHand;
        private Deck.Deck playerDeck;
        private IList<ICard> battleField;

        

        public Player()
        {
            this.lifepoints = 15;
            this.PlayerHand = new Hand();
            this.PlayerDeck = new Deck.Deck();
            this.battleField = new List<ICard>();
            this.ManaCrystals = 0;
            this.MaxManaCrystals = 0;
        }
        public int Lifepoints
        {
            get
            {
                return this.lifepoints;
            }
            set
            {
                this.lifepoints = value;
            }
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

        public IList<ICard> BattleField
        {
            get
            {
                return this.battleField;
            }
            set
            {
                this.battleField = value;
            }
        }

        

        public void PrintCardsOnBattleField()
        {
            foreach (var card in this.battleField)
            {
                card.ShowInfo();
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

