using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Deck
{
    public class DeckCollection
    {
        private static Random random;

        private List<Deck> myDecks;

        static DeckCollection()
        {
            random = new Random();
        }

        public DeckCollection()
        {
            this.myDecks = new List<Deck>();
        }

        internal Deck GetRandomDeck()
        {
            int randomIndex = random.Next(0, myDecks.Count);

            return myDecks[randomIndex];
        }
    }
}
