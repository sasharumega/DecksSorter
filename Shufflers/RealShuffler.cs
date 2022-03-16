using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecksSorter.Shufflers
{
    class RealShuffler : IShuffler
    {
        Random random = new Random(DateTime.Now.Millisecond);

        public List<T> GetShuffledItems<T>(List<T> items)
        {
            for (int i = 0; i < items.Count(); i++)
            {
                int k = random.Next(i + 1);
                T value = items[k];
                items[k] = items[i];
                items[i] = value;
            }
            return items;
        }
    }
}
