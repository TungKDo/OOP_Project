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
            Console.WriteLine("Welcome to Hearthstone Rip Off");
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
       
    }
}