using HearthStone_Rip_Off.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace HearthStone_Rip_Off.Common
{
   public static class ExtensionCardCollection
    {
        public static ICard TakeCard<T>(this IList<T> collection, string nameOfCard) where T : ICard
        {
            ICard card = collection.FirstOrDefault(x => x.CardName.ToLower() == nameOfCard.ToLower());

            return card;
        }
    }
}
