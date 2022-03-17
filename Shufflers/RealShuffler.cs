using System;
using System.Collections.Generic;
using System.Linq;

namespace DecksSorter.Shufflers
{
    class RealShuffler : IShuffler
    {
        private readonly Random random = new Random(DateTime.Now.Millisecond);

        public List<T> GetShuffledItems<T>(List<T> items)
        {
            int k;
            for (int i = 0; i < items.Count; i++)
            {
                k = random.Next(i + 1);
                (items[k], items[i]) = (items[i], items[k]);
            }
            return items;
        }
    }
}
