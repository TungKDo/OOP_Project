using HearthStone_Rip_Off.BattleField;
using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells.List_of_Spells;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Deck;
using HearthStone_Rip_Off.Engine_Stuffs;
using System;
using System.Collections.Generic;

namespace HearthStone_Rip_Off
{
    public static class GameEngine
    {
        private const int InitialPlayerLifePoints = 15;
        private static DeckCollection deckCollection = DeckCollection.Instance;
        
        
        public static void Run()
        {
            Console.WriteLine("Welcome to BattleArena");
            Console.WriteLine("Choose an item from the menu below");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Deck Collection");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            bool isInValidInput = false;

            while(!isInValidInput)
            {
                switch (input)
                {
                    case "1":
                        {
                            PlayGame.NewGame();
                            break;
                        }
                    case "2":
                        {
                            DeckCollectionManagement.ManageDeckCollection();
                            break;
                        }
                    case "3":
                        {
                            ShowCredits();
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

        

        

        private static void ShowCredits()
        {
            Console.WriteLine($"===========================\n" +
                $"This game was created by:\nAlexandra Petrova\nBorislav Borisov\nTung Do\n" +
                $"===========================\n\n");
            Run();
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }


        private static void StartNewGame()
        {

            

            //PlayerDeck player1Deck = new PlayerDeck();
            //PlayerDeck player2Deck = new PlayerDeck();


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

       

        
    }
}