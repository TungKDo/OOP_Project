using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Deck
{
    public class DeckCollection
    {
        private static readonly DeckCollection instance = new DeckCollection();

        private readonly IDictionary<string, Deck> myDecks = new Dictionary<string, Deck>();

        private DeckCollection()
        {
        }

        public static DeckCollection Instance
        {
            get
            {
                return instance;
            }
        }

        public void CreateDeck(string deckName)
        {
            myDecks.Add(deckName, new Deck());
        }

        public IDictionary<string, Deck> MyDeck
        {
            get
            {
                return new Dictionary<string, Deck>(this.myDecks);
            }
        }

        public void RemoveDeck(string deckName)
        {
            myDecks.Remove(deckName);
        }

        
    }
}
