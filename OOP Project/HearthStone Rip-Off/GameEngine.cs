using HearthStone_Rip_Off.BattleField;
using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells.List_of_Spells;
using HearthStone_Rip_Off.Deck;
using System;
using System.Collections.Generic;

namespace HearthStone_Rip_Off
{
    public class GameEngine
    {
        private const int InitialPlayerLifePoints = 15;
        private DeckCollection deckCollection = new DeckCollection();
        

        public GameEngine()
        {
            //this.deckCollection = new DeckCollection();
            //this.deckCollection.Generate(deckCount: 5, deckSize: 3);
        }

        
        public void Run()
        {
            Console.WriteLine("Welcome to BattleArena");
            Console.WriteLine("Choose an item from the menu below");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Deck Collection");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            bool isInValidInput = false;

            while(!isInValidInput)
            {
                switch (input)
                {
                    case "1":
                        {
                            StartNewGame();
                            break;
                        }
                    case "2":
                        {
                            ManageDeckCollection();
                            break;
                        }

                    case "4":
                        {
                            Exit();
                            break;
                        }
                    default:
                        {
                            isInValidInput = true;
                            break;
                        }
                }
            }
        }

        private void ManageDeckCollection()
        {
            Console.WriteLine("1. Create Deck");
            Console.WriteLine("2. Delete Deck");
            Console.WriteLine("3. Add cards to an existing Deck");
            string input = Console.ReadLine();

            

            while(input != "5")
            {
                switch(input)
                {
                    case "1":
                        Console.WriteLine("Please type in the deck name");
                        string deckName = Console.ReadLine();
                        deckCollection.CreateDeck(deckName);
                        ManageDeckCollection();
                        break;

                    case "2":
                        Console.WriteLine("Please type in the deck name");
                        string deckName1 = Console.ReadLine();
                        deckCollection.RemoveDeck(deckName1);
                        ManageDeckCollection();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the name of the deck you would like to add cards to:");
                        foreach (string key in deckCollection.MyDeck.Keys)
                        {                            
                            Console.WriteLine(key);
                        }                        
                        string deckName3 = Console.ReadLine();
                        deckCollection.MyDeck[deckName3]

                        ManageDeckCollection();
                        break;                        
                        
                }
                    

            }
        }

        private void StartNewGame()
        {

            

            //PlayerDeck player1Deck = new PlayerDeck();
            //PlayerDeck player2Deck = new PlayerDeck();

            //player1Deck.

            //player1Deck.MyDeck.Add(new ChillWindYeti());
            //player1Deck.MyDeck.Add(new Demon("Demon", 7, 7, 7));
            //player1Deck.MyDeck.Add(new EmperorCobra("EmperorCobra", 3, 3, 3));
            //player1Deck.MyDeck.Add(new ManaWyrm("Manawyrm", 1, 1, 3));

            //player2Deck.MyDeck.Add(new Ogre("Ogre", 6, 6, 7));
            //player2Deck.MyDeck.Add(new SwampOoze("SwampOoze", 2, 3, 2));
            //player2Deck.MyDeck.Add(new Tiger("Tiger", 5, 5, 5));
            //player2Deck.MyDeck.Add(new WaterElemental("WaterElemental", 4, 3, 6));

            //player1Deck.Shuffle();
            //player2Deck.Shuffle();


            //Hand player1Hand = new Hand();
            //Hand player2Hand = new Hand();

            //Player player1 = new Player(15 ,player1Deck,player1Hand);
            //Player player2 = new Player(15 ,player2Deck, player1Hand);


            //GameInitialization();



            //    bool isFirstPlayerMove = true;
            //    Player winner = null;

            //    while (true)
            //    {
            //        string playerInput = Console.ReadLine();

            //        // do battle

            //        if(isFirstPlayerMove && player2.LifePoints <= 0)
            //        {
            //            winner = player1;
            //            break;
            //        }
            //        else if(!isFirstPlayerMove && player1.LifePoints <= 0)
            //        {
            //            winner = player2;
            //            break;
            //        }

            //        isFirstPlayerMove = !isFirstPlayerMove;
            //    }

            //    Console.WriteLine("The winner is: {0}", winner);
            //}

            //private void GameInitialization(PlayerDeck player1Deck, Player, PlayerDeck player2Deck)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {

            //        var currentCard = player1Deck.MyDeck[0];
            //        player1Hand.MyHand.Add(currentCard);
            //        player1Deck.MyDeck.Remove(currentCard);
            //    }
            //    for (int i = 0; i < 3; i++)
            //    {
            //        var currentCard = player2Deck.MyDeck[0];
            //        player2Hand.MyHand.Add(currentCard);
            //        player2Deck.MyDeck.Remove(currentCard);
            //    }
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}