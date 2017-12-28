using HearthStone_Rip_Off.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Engine_Stuffs
{
      
    public static class PlayGame
    {
        private static DeckCollection deckCollection = DeckCollection.Instance;

        public static void NewGame()
        {
            Console.WriteLine("Player 1 please choose your deck:");
            foreach (string key in deckCollection.MyDeck.Keys)
            {
                Console.WriteLine(key);
            }            
            Deck.Deck player1deck =  deckCollection.MyDeck[Console.ReadLine()]; //Трябва да погледнем как се прави deep copy тук,
            player1deck.Shuffle();                                             //защото shallow copy ще прецеката колекциите в тестетата
            Console.WriteLine("Player 2 please choose your deck:");
            Deck.Deck player2deck = deckCollection.MyDeck[Console.ReadLine()];
            player2deck.Shuffle();
            

            Player player1 = new Player(player1deck);
            Player player2 = new Player(player2deck);
            player1.DrawThreeCards();
            player2.DrawThreeCards();

        }

    }
}
