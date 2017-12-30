using HearthStone_Rip_Off.Deck;
using System;

namespace HearthStone_Rip_Off.Common
{
    public static class Check
    {
        public static bool StringIsNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("The string was not in correct format. Null or empty.");
                return true;
            }

            return false;
        }

        public static bool IfDeckExists(DeckCollection collection, string nameOfDeck)
        {
            if (!collection.MyDeck.ContainsKey(nameOfDeck))
            {
                Console.WriteLine("The deck doesn't exist.");
                return false;
            }

            return true;
        }

        public static bool IfDeckIsFull(DeckCollection collection, string nameOfDeck)
        {
            if (collection.MyDeck[nameOfDeck].Cards.Count >= 10)
            {
                Console.WriteLine("The curent deck is full.");
                return true;
            }

            return false;
        }

        public static bool IfDeckIsEmpty(DeckCollection collection, string nameOfDeck)
        {
            if(collection.MyDeck[nameOfDeck].Cards.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return true;
            }

            return false;
        }
    }
}
