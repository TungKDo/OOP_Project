using HearthStone_Rip_Off.Deck;
using System;
using PlayerDeck = HearthStone_Rip_Off.Deck.Deck;

namespace HearthStone_Rip_Off
{
    public class GameEngine
    {
        private const int InitialPlayerLifePoints = 15;
        private DeckCollection deckCollection;

        public GameEngine()
        {
            this.deckCollection = new DeckCollection();
            //this.deckCollection.Generate(deckCount: 5, deckSize: 3);
        }

        public void Run()
        {
            Console.WriteLine("Welcome to BattleArena");
            Console.WriteLine("Choose an item from the menu below");
            Console.WriteLine("1. New Game");
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

        private void StartNewGame()
        {
            PlayerDeck player1Deck = this.deckCollection.GetRandomDeck();
            PlayerDeck player2Deck = this.deckCollection.GetRandomDeck();

            Player player1 = new Player(player1Deck, InitialPlayerLifePoints);
            Player player2 = new Player(player2Deck, InitialPlayerLifePoints);

            bool isFirstPlayerMove = true;
            Player winner = null;

            while (true)
            {
                string playerInput = Console.ReadLine();
                
                // do battle

                if(isFirstPlayerMove && player2.LifePoints <= 0)
                {
                    winner = player1;
                    break;
                }
                else if(!isFirstPlayerMove && player1.LifePoints <= 0)
                {
                    winner = player2;
                    break;
                }

                isFirstPlayerMove = !isFirstPlayerMove;
            }

            Console.WriteLine("The winner is: {0}", winner);
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}