using System;
using System.Linq;
using HearthStone_Rip_Off.Contracts;
using System.Collections.Generic;
using HearthStone_Rip_Off.Deck;

namespace HearthStone_Rip_Off.BattleField
{
    public class Hand
    {
        //    private DeckCollection decks;
        //    private Deck.Deck deck;
        //    private List<ICard> cardsInHand;

        //    public Hand()
        //    {
        //        this.decks = new DeckCollection();
        //        this.deck = this.decks.GetRandomDeck();
        //    }

        //    public void PrintHand()
        //    {
        //        foreach (var card in deck)
        //        {
        //            Console.WriteLine(String.Join(",", card)); //TODO all cards should have ToString() ovveride
        //        }
        //    }

        //    public void PullCard()
        //    {
        //        if(deck.Cards.Count == 0)
        //            Console.WriteLine("The deck is empty.");

        //        this.cardsInHand.Add(deck.Cards.First());
        //        this.deck.Cards.RemoveAt(0);
        //    }

        //    public ICard PlayCard(int i) //i = index of one of the 3 cards in cardsInHand, 1,2,3
        //    {
        //        return this.cardsInHand[i - 1];
        //    }

    }
}
