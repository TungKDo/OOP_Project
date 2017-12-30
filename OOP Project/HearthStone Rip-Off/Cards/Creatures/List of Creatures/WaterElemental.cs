using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class WaterElemental : Creature
    {
        public WaterElemental()
            : base("WaterElemental", 6, 4, 3, CreatureType.Elemental)
        {
        }
    }
}
