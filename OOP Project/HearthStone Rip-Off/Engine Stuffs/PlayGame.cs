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
            if(player.PlayerDeck.Cards.Count > 0)
            {
                player.DrawACards();
            }
            

            // Foreach that showinfo for all cards in hand
                
        }

        private static void PlayTurn(Player player, Player opponent)
        {
            Console.WriteLine("1. Play a Monster");
            Console.WriteLine("2. Cast a Spell");
            Console.WriteLine("3. Attack opponent's creature with your creature");
            Console.WriteLine("4. Attack the opponent hero with your creature");
            Console.WriteLine("8. End Turn");
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input =="8")
                {
                    break;
                }
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please enter the name of the creature you would like to play:");
                        foreach (ICard cardName in player.PlayerHand.CardsInHand)
                        {
                            if(cardName.IsCreature()) cardName.ShowInfo();                        } 
                        
                        string creatureName = Console.ReadLine().ToLower();
                        ICard creatureToBePlayed = player.PlayerHand.CardsInHand.FirstOrDefault(x => x.CardName.ToLower() == creatureName); //Проверка!
                        player.PlayerHand.Remove(creatureToBePlayed);
                        player.BattleField.Add(creatureToBePlayed);
                        break;

                    case "2":
                        Console.WriteLine("Please enter the name of the spell would like to play:");
                        foreach (ICard cardName in player.PlayerHand.CardsInHand)
                        {
                            if (cardName.IsCreature() == false) cardName.ShowInfo();
                        }                        
                        string spellName = Console.ReadLine().ToLower();
                        ISpell spellToBePlayed = (ISpell)player.PlayerHand.CardsInHand.FirstOrDefault(x => x.CardName.ToLower() == spellName);
                        Console.WriteLine("Target:");
                        Console.WriteLine("1.Opponent's hero");
                        Console.WriteLine("2.Opponent's creature ");
                        string target = Console.ReadLine();
                        switch (target)
                        {
                            case "1":
                                CastSpellOnHero(spellToBePlayed, opponent);
                                player.PlayerHand.Remove(spellToBePlayed);
                                break;
                            case "2":
                                if(opponent.BattleField.Count > 0)
                                {
                                    foreach (ICard cardName in opponent.BattleField)
                                    {
                                        cardName.ShowInfo();
                                    }
                                    Console.WriteLine("Please enter the name of the creature you would like to target:");
                                    string creatureName2 = Console.ReadLine().ToLower();
                                    ICreature creatureToBeTargeted = (ICreature)opponent.BattleField.FirstOrDefault(x => x.CardName.ToLower() == creatureName2);
                                    CastSpellOnCreature(spellToBePlayed, creatureToBeTargeted);
                                    if(creatureToBeTargeted.HealthPoints < 1)
                                    {
                                        opponent.BattleField.Remove(creatureToBeTargeted);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opponent doesn't have any creatures on the battlefield");
                                    PlayTurn(player, opponent);
                                }
                                break;
                               
                        }
                        break;
                    case "3":
                        if(opponent.BattleField.Count == 0)
                        {
                            Console.WriteLine("Opponent doesn't have any creatures on the battlefield");
                            PlayTurn(player, opponent);
                        }
                        else
                        {
                            Console.WriteLine("Please enter the name of the creature you would like to attack with:");
                            foreach (ICard cardName in player.BattleField)
                            {
                                if (cardName.IsCreature() == true) cardName.ShowInfo();
                            }
                            string creatureName3 = Console.ReadLine().ToLower();
                            ICreature myCreature = (ICreature)player.BattleField.FirstOrDefault(x => x.CardName.ToLower() == creatureName3);

                            Console.WriteLine("Please enter the name of the creature you would like to attack:");
                            foreach (ICard cardName in opponent.BattleField)
                            {
                                if (cardName.IsCreature() == true) cardName.ShowInfo();
                            }
                            creatureName3 = Console.ReadLine().ToLower();
                            ICreature oppoCreature = (ICreature)opponent.BattleField.FirstOrDefault(x => x.CardName.ToLower() == creatureName3);
                            BattleBetween2Creatures(myCreature, oppoCreature);
                            if (myCreature.HealthPoints < 1)
                            {
                                player.BattleField.Remove(myCreature);
                            }
                            if (oppoCreature.HealthPoints < 1)
                            {
                                opponent.BattleField.Remove(oppoCreature);
                            }                            
                        }
                        break;

                    case "4":
                        Console.WriteLine("Please enter the name of the creature you would like to attack with:");
                        foreach (ICard cardName in player.BattleField)
                        {
                            if (cardName.IsCreature() == true) cardName.ShowInfo();
                        }
                        string creatureName4 = Console.ReadLine();
                        ICreature myCreature2 = (ICreature)player.BattleField.FirstOrDefault(x => x.CardName.ToLower() == creatureName4);
                        CreatureAttackHero(myCreature2, opponent);
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

        private static void CreatureAttackHero(ICreature myCreature, Player opponent)
        {
            opponent.LifePoints -= myCreature.AttackPoints;
        }

        private static void BattleBetween2Creatures(ICreature myCreature, ICreature opponentCreature)
        {
            myCreature.HealthPoints -= opponentCreature.AttackPoints;
            opponentCreature.HealthPoints -= myCreature.AttackPoints;
        }

        private static void CastSpellOnCreature(ISpell spellToBePlayed, ICreature creatureToBeTargeted)
        {
            int damageToBeInflicted = spellToBePlayed.Damage;
            creatureToBeTargeted.HealthPoints -= damageToBeInflicted;
        }

        private static void CastSpellOnHero(ISpell spellToBePlayed, Player opponent)
        {
            int damageToBeInflicted = spellToBePlayed.Damage;
            opponent.LifePoints -= damageToBeInflicted;
        }
    }
}
