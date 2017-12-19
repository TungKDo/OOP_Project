using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.Deck
{
    public class Deck : List<ICard>
    {
        

        private IList<ICard> myDeck;



        public Deck()
        {
            this.MyDeck = new List<ICard>();
        }

        public IList<ICard> MyDeck
        {
            get
            {
                return this.myDeck;
            }
            set
            {
                this.myDeck = value;
            }
        }

        public void Shuffle()
        {
            IList<ICard> shuffleddeck = new List<ICard>();
            Random rnd = new Random();
            while (myDeck.Count >0 )
            {                
                int r = rnd.Next(0 ,myDeck.Count);
                shuffleddeck.Add(myDeck[r]);
                myDeck.Remove(myDeck[r]);
            }
            this.MyDeck = shuffleddeck;
        }
    }

}
