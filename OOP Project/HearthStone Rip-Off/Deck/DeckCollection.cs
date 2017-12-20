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
        private Random random;
        private Deck deckOfAllcards;
        private List<Deck> myDecks;
        
        public DeckCollection()
        {
            InitializeCreaturesAndSpells(deckOfAllcards);
        }

        //public List<Deck> MyDeck
       

        internal Deck GetRandomDeck()
        {
            int randomIndex = random.Next(0, myDecks.Count);

            return myDecks[randomIndex];
        }

        
    }
}
