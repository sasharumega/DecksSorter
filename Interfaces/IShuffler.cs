using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecksSorter
{
    public interface IShuffler
    {
        /// <summary>
        /// Возвращает перемешанный лист элементов
        /// </summary>
        /// <param name="items">Элементы</param>
        List<T> GetShuffledItems<T>(List<T> items);
    }
}
