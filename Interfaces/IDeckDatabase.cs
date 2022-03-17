using System.Collections.Generic;

namespace DecksSorter.Interfaces
{
    public interface IDeckDatabase
    {
        /// <summary>
        /// Добавление колоды карт в хранилище
        /// </summary>
        /// <param name="deck">Колода карт</param>
        void AddDeck(Deck deck);

        /// <summary>
        /// Получение колоды по имени
        /// </summary>
        /// <param name="name">Имя колоды карт</param>
        Deck GetDeck(string name);

        /// <summary>
        /// Удаление колоды по имени
        /// </summary>
        /// <param name="name">Имя колоды карт</param>
        void DeleteDeck(string name);

        /// <summary>
        /// Проверка наличия колоды по имени
        /// </summary>
        /// <param name="name">Имя колоды карт</param>
        bool ExistDeck(string name);

        /// <summary>
        /// Получение списка всех колод карт
        /// </summary>
        List<Deck> GetAllDecks();
    }
}
