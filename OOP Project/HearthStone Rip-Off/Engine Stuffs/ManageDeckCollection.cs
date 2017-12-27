using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells.List_of_Spells;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Engine_Stuffs
{
    public static class DeckCollectionManagement
    {

        private static DeckCollection deckCollection = DeckCollection.Instance;

        public static void ManageDeckCollection()
        {
            Console.WriteLine("1. Create Deck");
            Console.WriteLine("2. Delete Deck");
            Console.WriteLine("3. Add cards to an existing Deck");
            Console.WriteLine("4. Remove cards to an existing Deck");
            Console.WriteLine("5. List all cards in a deck");
            Console.WriteLine("6. Back");
            string input = Console.ReadLine();

            while (true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please type in the deck name");
                        string deckName1 = Console.ReadLine();
                        deckCollection.CreateDeck(deckName1);
                        ManageDeckCollection();
                        break;

                    case "2":
                        Console.WriteLine("Please type in the deck name");
                        string deckName2 = Console.ReadLine();
                        deckCollection.RemoveDeck(deckName2);
                        ManageDeckCollection();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the name of the deck you would like to add cards to:");
                        foreach (string key in deckCollection.MyDeck.Keys)
                        {
                            Console.WriteLine(key);
                        }
                        string deckName3 = Console.ReadLine();
                        Console.WriteLine("Please enter the name of the cards that you want to remove:");
                        Console.WriteLine("When done, please type exit ");
                        while (true)
                        {
                            string cardToBeAdded = Console.ReadLine();
                            if (cardToBeAdded == "exit")
                            {
                                break;
                            }
                            deckCollection.MyDeck[deckName3].Add(CardFactory(cardToBeAdded));
                        }
                        ManageDeckCollection();
                        break;
                    case "4":
                        Console.WriteLine("Please enter the name of the deck you would like to remove cards from:");
                        foreach (string key in deckCollection.MyDeck.Keys)
                        {
                            Console.WriteLine(key);
                        }
                        string deckName4 = Console.ReadLine();
                        Console.WriteLine("Please enter the name of the cards that you want to remove:");
                        Console.WriteLine("When done, please type exit ");
                        while (true)
                        {
                            string cardToBeRemoved = Console.ReadLine();
                            if (cardToBeRemoved == "exit")
                            {
                                break;
                            }
                            ICard card = deckCollection.MyDeck[deckName4].Cards.FirstOrDefault(x => x.CardName.ToLower() == cardToBeRemoved);
                            deckCollection.MyDeck[deckName4].Remove(card);
                        }
                        ManageDeckCollection();
                        break;

                    case "5":
                        Console.WriteLine("Please enter the name of the deck you would like to list all cards of:");
                        foreach (string key in deckCollection.MyDeck.Keys)
                        {
                            Console.WriteLine(key);
                        }
                        string deckName5 = Console.ReadLine();

                        foreach (ICard card in deckCollection.MyDeck[deckName5].Cards)
                        {
                            Console.WriteLine(card.CardName);
                            Console.WriteLine("===========================");
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
        private static ICard CardFactory(string cardToBeAdded)
        {
            cardToBeAdded = cardToBeAdded.ToLower();
            switch (cardToBeAdded)
            {
                case "chillwindyeti":
                    {
                        return new ChillWindYeti();
                    }
                case "emperorcobra":
                    {
                        return new EmperorCobra();
                    }
                case "manawyrm":
                    {
                        return new ManaWyrm();
                    }
                case "ogre":
                    {
                        return new Ogre();
                    }
                case "swampooze":
                    {
                        return new SwampOoze();
                    }
                case "tiger":
                    {
                        return new Tiger();
                    }
                case "waterelemental":
                    {
                        return new WaterElemental();
                    }
                case "fireball":
                    {
                        return new FireBall();
                    }
                case "fireblast":
                    {
                        return new FireBlast();
                    }
                case "frostbolt":
                    {
                        return new FrostBolt();
                    }
                default:
                    {
                        return new FrostBolt();
                    }


            }

        }
    }
}
