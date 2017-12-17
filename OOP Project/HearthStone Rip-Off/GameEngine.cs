using HearthStone_Rip_Off.BattleField;
using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
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
            PlayerDeck player1Deck = new PlayerDeck();
            PlayerDeck player2Deck = new PlayerDeck();



            player1Deck.MyDeck.Add(new ChillWindYeti("ChillWindYeti", 4, 4, 5));
            player1Deck.MyDeck.Add(new Demon("Demon", 7, 7, 7));
            player1Deck.MyDeck.Add(new EmperorCobra("EmperorCobra", 3, 3, 3));
            player1Deck.MyDeck.Add(new ManaWyrm("Manawyrm", 1, 1, 3));

            player2Deck.MyDeck.Add(new Ogre("Ogre", 6, 6, 7));
            player2Deck.MyDeck.Add(new SwampOoze("SwampOoze", 2, 3, 2));
            player2Deck.MyDeck.Add(new Tiger("Tiger", 5, 5, 5));
            player2Deck.MyDeck.Add(new WaterElemental("WaterElemental", 4, 3, 6));

            player1Deck.Shuffle();
            player2Deck.Shuffle();


            Hand player1Hand = new Hand();
            Hand player2Hand = new Hand();

            Player player1 = new Player(15 ,player1Deck,player1Hand);
            Player player2 = new Player(15 ,player2Deck, player1Hand);

            for (int i = 0; i < 3; i++)
            {

                var currentCard = player1Deck.MyDeck[0];                
                player1Hand.MyHand.Add(currentCard);
                player1Deck.MyDeck.Remove(currentCard);
            }
            for (int i = 0; i < 3; i++)
            {
                var currentCard = player2Deck.MyDeck[0];                
                player2Hand.MyHand.Add(currentCard);
                player2Deck.MyDeck.Remove(currentCard);
            }

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