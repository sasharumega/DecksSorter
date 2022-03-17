using System.Collections.Generic;

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
