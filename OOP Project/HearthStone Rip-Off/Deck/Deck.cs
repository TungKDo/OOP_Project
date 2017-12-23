using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Deck
{
    public class Deck //: IEnumerable
    {
        private IList<ICard> cards;

        public Deck()
        {
            this.cards = new List<ICard>();
        }

        public IList<ICard> Cards
        {
            get
            {
                return new List<ICard>(this.cards);
            }
            set //protected?
            {
                this.cards = value;
            }
        }

        protected void Add(ICard card)
        {
            CheckIfCardIsNull(card);
            this.cards.Add(card);
        }

        protected void Remove(ICard card)
        {
            CheckIfCardIsNull(card);
            this.cards.Remove(card);
        }

        public void Shuffle()
        {
            IList<ICard> shuffledDeck = new List<ICard>();

            Random rnd = new Random();

            while (this.cards.Count > 0)
            {
                int r = rnd.Next(0, this.cards.Count);
                shuffledDeck.Add(this.cards[r]);
                this.cards.Remove(this.cards[r]);
            }
            this.cards = shuffledDeck;
        }

        public void InitializeCreaturesAndSpells(Deck deck)
        {
            deck.Cards = new List<ICard>
            {
                new ChillWindYeti(),
                new EmperorCobra()
            };

            Shuffle();
        }
        private void CheckIfCardIsNull(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("The card cannot be null.");
            }
        }
    }
}

