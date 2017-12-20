using System.Collections.Generic;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Creatures;
namespace HearthStone_Rip_Off.Deck
{
    public static class ExtensionMethodsDeck
    {
        public static void Shuffle(this Deck deck)
        {
            IList<ICard> shuffleddeck = new List<ICard>();
            Random rnd = new Random();
            while (deck.Count > 0)
            {
                int r = rnd.Next(0, deck.Count);
                shuffleddeck.Add(deck[r]);
                deck.Remove(deck[r]);
            }
            this.MyDeck = shuffleddeck;
        }
    }
}
