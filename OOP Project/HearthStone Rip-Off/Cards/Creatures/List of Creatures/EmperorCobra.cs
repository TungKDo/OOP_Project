using System.Text;
using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures
{
    public class EmperorCobra : Creature
    {
        public EmperorCobra(string cardName = "EmperorCobra", uint manaCost = 3, uint attackPoints = 3,
            int healthPoints = 3, CreatureType type = CreatureType.Beast)
            : base(cardName, manaCost, attackPoints, healthPoints, type)
        {

        }
    }
}
