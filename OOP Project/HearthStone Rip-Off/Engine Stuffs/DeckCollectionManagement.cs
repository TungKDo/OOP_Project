using HearthStone_Rip_Off.Common;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Deck;
using System;
using System.Linq;
using HearthStone_Rip_Off.Factory;

namespace HearthStone_Rip_Off.Engine_Stuffs
{
    public static class DeckCollectionManagement
    {
        private static DeckCollection deckCollection = DeckCollection.Instance;

        public static void ManageDeckCollection()
        {
            Console.WriteLine("\n1. Create Deck");
            Console.WriteLine("2. Delete Deck");
            Console.WriteLine("3. Add cards to an existing Deck");
            Console.WriteLine("4. Remove cards to an existing Deck");
            Console.WriteLine("5. List all cards in a deck");
            Console.WriteLine("6. Back");
            string input = Console.ReadLine();
            string deckName;

            while (true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please type in the deck name");

                        deckName = Console.ReadLine().ToLower();

                        if (!Check.StringIsNullOrEmpty(deckName))
                        {
                            deckCollection.CreateDeck(deckName);
                        }

                        ManageDeckCollection();

                        break;

                    case "2":
                        Console.WriteLine("Please type in the deck name");

                        deckName = Console.ReadLine();

                        if (!Check.StringIsNullOrEmpty(deckName))
                        {
                            if (Check.IfDeckExists(deckCollection, deckName))
                            {
                                deckCollection.RemoveDeck(deckName);
                            }
                        }

                        ManageDeckCollection();
                        break;

                    case "3":
                        Console.WriteLine("Please enter the name of the deck you would like to add cards to:");

                        foreach (string key in deckCollection.MyDeck.Keys)
                        {
                            Console.WriteLine(key);
                        }

                        deckName = Console.ReadLine();

                        if (!Check.StringIsNullOrEmpty(deckName) && !Check.IfDeckExists(deckCollection, deckName))
                        {
                            ManageDeckCollection();
                        }

                        Console.WriteLine("Please enter the name of the cards that you want to add:");
                        Console.WriteLine("When done, please type exit ");

                        while (true)
                        {
                            string cardToBeAdded = Console.ReadLine();

                            if (cardToBeAdded == "exit")
                            {
                                break;
                            }
                            foreach (ICard card in deckCollection.MyDeck[deckName])
                            {
                                if (card.CardName.ToLower() == cardToBeAdded)
                                {
                                    Console.WriteLine("You already have this card in this deck.");
                                    ManageDeckCollection();
                                }
                            }

                            if (!Check.IfDeckIsFull(deckCollection, deckName))
                            {
                                deckCollection.MyDeck[deckName].Add(CardFactory.CreateCard(cardToBeAdded));
                            }
                        }

                        ManageDeckCollection();
                        break;

                    case "4":
                        Console.WriteLine("Please enter the name of the deck you would like to remove cards from:");

                        Print.PrintDeckCollectionKeys(deckCollection);

                        deckName = Console.ReadLine();

                        if (!Check.StringIsNullOrEmpty(deckName) && !Check.IfDeckExists(deckCollection, deckName))
                        {
                            ManageDeckCollection();
                        }

                        Console.WriteLine("Please enter the name of the cards that you want to remove:");
                        Console.WriteLine("When done, please type exit ");

                        while (true)
                        {
                            string cardToBeRemoved = Console.ReadLine();

                            if (cardToBeRemoved == "exit")
                            {
                                break;
                            }

                            ICard card = deckCollection.MyDeck[deckName].Cards.FirstOrDefault(x => x.CardName.ToLower() == cardToBeRemoved);

                            if (card == null)
                            {
                                Console.WriteLine("The card doesn't exist or it is null.");
                                continue;
                            }

                            deckCollection.MyDeck[deckName].Remove(card);
                        }

                        ManageDeckCollection();
                        break;

                    case "5":
                        Console.WriteLine("Please enter the name of the deck you would like to list all cards of:");

                        Print.PrintDeckCollectionKeys(deckCollection);

                        deckName = Console.ReadLine();

                        if (!Check.StringIsNullOrEmpty(deckName))
                        {
                            if (Check.IfDeckExists(deckCollection, deckName))
                            {
                                if (!Check.IfDeckIsEmpty(deckCollection, deckName))
                                {
                                    foreach (ICard card in deckCollection.MyDeck[deckName].Cards)
                                    {
                                        Console.WriteLine(card.CardName);
                                        Console.WriteLine("===========================");
                                    }
                                }
                            }
                        }

                        ManageDeckCollection();
                        break;

                    case "6":
                        GameEngine.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        ManageDeckCollection();
                        break;
                }
            }
        }
    }
}
