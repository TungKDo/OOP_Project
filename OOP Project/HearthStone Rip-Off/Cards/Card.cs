using HearthStone_Rip_Off.Contracts;

namespace HearthStone_Rip_Off.Cards
{
    public abstract class Card : ICard
    {
        private string cardName;
        private uint manaCost;

        public string CardName
        {
            get { return this.cardName; }
            protected set { this.cardName = value; }
        }

        public uint ManaCost
        {
            get { return this.manaCost; }
            protected set { this.manaCost = value; }
        }

        public virtual string ShowInfo()
        {
            return "";
        }

    }
}
