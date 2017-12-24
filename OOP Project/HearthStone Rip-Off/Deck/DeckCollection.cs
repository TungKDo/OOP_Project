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
        private const int countOfDecks = 3;

        private Random random;
        private Deck deck;
        private IList<Deck> allDecks;

        public DeckCollection()
        {
            this.deck = new Deck();
            this.deck.InitializeAllCards(deck);
        }

        public Deck GetRandomDeck()
        {
            CreateDecks();

            int randomIndex = random.Next(0, allDecks.Count);

            return allDecks[randomIndex];
        }

        private void CreateDecks()
        {
            this.allDecks = new List<Deck>();

            PopulateWithDecks();
        }

        private void PopulateWithDecks()
        {
            Deck newDeck = new Deck();

            int countOfAllCards = deck.Cards.Count;

            int portionToTake = countOfAllCards % countOfDecks;

            for (int i = 0; i < countOfAllCards; i += portionToTake)
            {
                newDeck.Cards = deck.Cards.Skip(i).Take(portionToTake).ToList();
                this.allDecks.Add(newDeck); //yield
            }
        }
    }
}
