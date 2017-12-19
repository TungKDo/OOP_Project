using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthStone_Rip_Off
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngine engine = new GameEngine();

            engine.Run();




            //Deck.Deck deck = new Deck.Deck();

            //deck.Add(new ManaWyrm());

            //deck.Shuffle();
        }
    }
}
