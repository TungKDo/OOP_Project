using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class WaterElemental : Creature
    {
        public WaterElemental(string cardName = "WaterElemental", uint manaCost = 4, uint attackPoints = 3,
            int healthPoints = 6, CreatureType type = CreatureType.Elemental)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
