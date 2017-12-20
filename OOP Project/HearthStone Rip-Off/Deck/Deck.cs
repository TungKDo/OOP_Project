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
    public class Deck<ICard> : IEnumerable
    {
        const int DefaultCapacity = 4096;

        private ICard[] cards;
        private int count = 0;


        public Deck(int capacity)
        {
            cards = new ICard[capacity];
        }

        public Deck() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(ICard element)
        {
            if (count >= cards.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", cards.Length));
            }
            this.cards[count] = element;
            count++;
        }

        public ICard this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                ICard result = cards[index];
                return result;
            }
        }


        public static void InitializeCreaturesAndSpells(Deck<ICard> deck)
        {
            deck = new Deck<ICard>
            {
                new ChillWindYeti(),
                new EmperorCobra()
            };
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
