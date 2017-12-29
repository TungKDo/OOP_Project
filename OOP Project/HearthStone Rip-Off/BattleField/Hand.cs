using System;
using System.Linq;
using HearthStone_Rip_Off.Contracts;
using System.Collections.Generic;
using HearthStone_Rip_Off.Deck;
using System.Collections;

namespace HearthStone_Rip_Off.BattleField
{
    public class Hand : IEnumerable
    {
        private IList<ICard> cardsInHand;

        public Hand()
        {
            this.cardsInHand = new List<ICard>();
        }

        public void PrintHand()
        {
            foreach (var card in cardsInHand)
            {
                Console.WriteLine(String.Join(",", card.CardName)); //TODO all cards should have ToString() ovveride
            }
        }
        
        public IList<ICard> CardsInHand
        {
            get
            {
                return new List<ICard>(this.cardsInHand);
            }

        }

        public void Add(ICard card)
        {            
            this.cardsInHand.Add(card);
        }

        public void Remove(ICard card)
        {
            this.cardsInHand.Remove(card);
        }

        public IEnumerator GetEnumerator()
        {
            return this.cardsInHand.GetEnumerator();
        }
    }
}
