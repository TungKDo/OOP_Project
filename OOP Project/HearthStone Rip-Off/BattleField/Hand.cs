using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off.BattleField
{
    public class Hand : List<ICard>
    {
        private ICollection<ICard> myHand;

        public Hand()
        {
            this.MyHand = new List<ICard>();
        }
        
        public void PrintHand()
        {
            foreach (var card in myHand)
            {
                Console.WriteLine(String.Join(",", card.CardName));
            }
        }

        public ICollection<ICard> MyHand
        {
            get
            {
                return this.myHand;
            }
            set
            {
                this.myHand = value;
            }
        }
    }
}
