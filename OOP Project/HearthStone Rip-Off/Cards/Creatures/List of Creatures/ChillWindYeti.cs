using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    class ChillWindYeti : Creature
    {
        public ChillWindYeti(string cardName = "ChillWindYeti", uint manaCost = 4, uint attackPoints = 4,
            int healthPoints = 5, CreatureType type = CreatureType.Beast)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {
        }
    }
}
