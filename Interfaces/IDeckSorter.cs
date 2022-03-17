using System.Collections.Generic;

namespace DecksSorter
{
    public interface IDeckSorter
    {
        /// <summary>
        /// Создание именованой колоды карт
        /// </summary>
        /// <param name="name">Название колоды карт</param>
        void CreateCardDeck(string name);

        /// <summary>
        /// Удаление именованой колоды карт
        /// </summary>
        /// <param name="name">Название колоды карт</param>
        void DeleteCardDeck(string name);

        /// <summary>
        /// Получение списка имен колод карт
        /// </summary>
        List<string> GetDecksNames();

        /// <summary>
        /// Перемешивание колоды карт
        /// </summary>
        /// <param name="name">Название колоды карт</param>
        void ShuffleCardDeck(string name);

        /// <summary>
        /// Получение колоды карт 
        /// </summary>
        /// <param name="name">Название колоды карт</param>
        /// <returns>Список карт</returns>
        Deck GetCardDeck(string name);
    }
}
