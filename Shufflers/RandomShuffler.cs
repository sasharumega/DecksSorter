using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecksSorter.Shufflers
{
    class RandomShuffler : IShuffler
    {
        public List<T> GetShuffledItems<T>(List<T> items)
        {
            return items.OrderBy(item => Guid.NewGuid()).ToList();
        }
    }
}
