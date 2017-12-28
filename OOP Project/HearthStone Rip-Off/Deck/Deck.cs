using HearthStone_Rip_Off.Cards.Creatures;
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
    public class Deck : IEnumerable
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

        public void Add(ICard card)
        {
            if (CheckIfCardIsNull(card))
            {
                Console.WriteLine("The card cannot be null.");
                return;
            }

            if (CheckIfListContainsCard(card))
            {
                Console.WriteLine("The list doesn't contains the card.");
                return;
            }

            this.cards.Add(card);
        }

        public void Remove(ICard card)
        {
            if (CheckIfCardIsNull(card))
            {
                Console.WriteLine("The card cannot be null.");
                return;
            }

            if (!CheckIfListContainsCard(card))
            {
                Console.WriteLine("The list doesn't contains the card.");
                return;
            }

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


        private bool CheckIfCardIsNull(ICard card)
        {
            bool isNull = false;

            if (card == null)
            {
                isNull = true;
            }

            return isNull;
        }

        public bool CheckIfListContainsCard(ICard card)
        {
            bool ifListContainsCard = true;

            if (!cards.Contains(card))
            {
                ifListContainsCard = false;
            }

            return ifListContainsCard;
        }

        public IEnumerator GetEnumerator()
        {
            return this.cards.GetEnumerator();
        }
    }
}

