using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerDeck = HearthStone_Rip_Off.Deck.Deck;

namespace HearthStone_Rip_Off
{
    public class Player
    {
        public Player(PlayerDeck deck, int lifePoints)
        {
            if(deck == null)
            {
                throw new ArgumentNullException(nameof(deck));
            }

            if (lifePoints <= 0)
            {
                throw new FormatException("The life points should be greater than zero");
            }

            Deck = deck;
            LifePoints = lifePoints;
        }

        public PlayerDeck Deck { get; private set; }

        public int LifePoints { get; private set; }
    }
}
