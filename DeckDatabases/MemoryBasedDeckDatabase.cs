using DecksSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecksSorter.DeckDatabases
{
    public class MemoryBasedDeckDatabase : IDeckDatabase
    {
        private readonly Dictionary<string, Deck> decks = new();

        public void AddDeck(Deck deck)
        {
            if (ExistDeck(deck.name))
                throw new Exception("Колода с таким именем уже существует");
            decks.Add(deck.name, deck);
        }

        public void DeleteDeck(string name)
        {
            if (!ExistDeck(name))
                throw new Exception("Колоды с таким именем не существует");
            decks.Remove(name);
        }

        public bool ExistDeck(string name)
        {
            return decks.ContainsKey(name);
        }

        public Deck GetDeck(string name)
        {
            if (!ExistDeck(name))
                throw new Exception("Колоды с таким именем не существует");
            return decks[name];
        }

        public List<Deck> GetAllDecks()
        {
            return decks.Values.ToList();
        }
    }
}
