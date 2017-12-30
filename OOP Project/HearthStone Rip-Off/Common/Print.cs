using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Deck;
using System;
using System.Collections.Generic;

namespace HearthStone_Rip_Off.Engine_Stuffs
{
    public static class Print
    {
        public static void PrintCards(ICollection<ICard> collection)
        {
            foreach (var card in collection)
            {
                card.ShowInfo();
            }
        }

        public static void PrintCreatures(ICollection<ICard> collection)
        {
            foreach (ICard cardName in collection)
            {
                if (cardName.IsCreature())
                    cardName.ShowInfo();
            }
        }

        public static void PrintSpells(ICollection<ICard> collection)
        {
            foreach (ICard cardName in collection)
            {
                if (cardName.IsCreature() == false)
                    cardName.ShowInfo();
            }
        }

        public static void PrintDeckCollectionKeys(DeckCollection collection)
        {
            foreach (string key in collection.MyDeck.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
