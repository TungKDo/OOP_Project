using HearthStone_Rip_Off.Cards;
using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Engine_Stuffs
{
      
    public static class PlayGame
    {
        private static DeckCollection deckCollection = DeckCollection.Instance;
        private static Player player1 = new Player();
        private static Player player2 = new Player();

        public static void NewGame()
        {
            //Pregame selection:

            // - Player Choose Decks and the decks are being shuffled 
            Console.WriteLine("Player 1 please choose your deck:");

            foreach (string key in deckCollection.MyDeck.Keys)
            {
                Console.WriteLine(key);
            }            

            Deck.Deck player1Deck =  deckCollection.MyDeck[Console.ReadLine()]; //Трябва да погледнем как се прави deep copy тук,
            player1Deck.Shuffle();                                            //защото shallow copy ще прецеката колекциите в тестетата
            Console.WriteLine("Player 2 please choose your deck:");
            Deck.Deck player2Deck = deckCollection.MyDeck[Console.ReadLine()];
            player2Deck.Shuffle();

            player1.PlayerDeck = player1Deck;
            player2.PlayerDeck = player2Deck;
            // - Player Draw Cards 
            for (int i = 0; i < 3; i++)
            {
                player1.DrawACards();
                player2.DrawACards();
            }
            

            string playerTurn = "P1";
            while (true)
            {
                if(playerTurn == "P1")
                {
                    Console.WriteLine("Player 2 Turn\n===========================");
                    StartOfTurn(player1);
                    PlayTurn(player1, player2);
                    playerTurn = "P2";
                }
                else
                {
                    Console.WriteLine("Player 2 Turn\n===========================");
                    PlayTurn(player2, player1);
                    playerTurn = "P1";
                } 
                

            }
        }

        private static void StartOfTurn(Player player)
        {
            if (player.MaxManaCrystals <= 10)
            {
                player.MaxManaCrystals += 1;
            }            
            player.ManaCrystals = player.MaxManaCrystals;
            player.DrawACards();

            // Foreach that showinfo for all cards in hand
                
        }

        private static void PlayTurn(Player player, Player opponent)
        {
            Console.WriteLine("1. Play a Monster");
            Console.WriteLine("2. Play a Spell");
            Console.WriteLine("3. Attack opponent's creature with your creature");
            Console.WriteLine("4. Attack the opponent hero with your creature");
            Console.WriteLine("8. End Turn");

            string input = Console.ReadLine();
            while (true)
            {                
                switch(input)
                {
                    case "1":
                        foreach(ICard cardName in player.PlayerHand.CardsInHand)
                        {
                            if(cardName.IsCreature())
                            cardName.ShowInfo();
                        }
                                                

                        Console.WriteLine("Please enter the name of the creature you would like to play:");

                        string creatureToBePlayed = Console.ReadLine().ToLower();

                        ICard cardToBePlayed = player.PlayerHand.CardsInHand.FirstOrDefault(x => x.CardName.ToLower() == creatureToBePlayed); //Проверка!


                        //player.PlayerHand.Remove(cardToBePlayed);
                        //player.BattleField.Add(cardToBePlayed);
                        
                        break;


                    case "8":
                        Console.WriteLine("Player ended his turn");
                        break;
                }
                    

            }
            //1.PlayCard
            //    - Creature
            //    - Spell
            //       - Monster
            //       - Hero
            //2.Attack
            //    - Attack Other Monster
            //    -Attack Hero
            //5.End Turn


        }
    }
}
