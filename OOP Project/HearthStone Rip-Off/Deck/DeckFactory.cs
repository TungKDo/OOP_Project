using System.Collections.Generic;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Deck
{
    class DeckFactory : Deck, IDeckFactory
    {
        private DeckCollection collectionsToChooseFrom;

        private Deck deck;

        public List<ICard> CreateNewDeck()
        {
            throw new System.NotImplementedException();
        }
        

    }
}
