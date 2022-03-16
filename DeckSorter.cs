using System;
using System.Collections.Generic;
using System.Linq;

namespace DecksSorter
{
    public class DeckSorter : IDeckSorter
    {
        public Dictionary<string, Deck> decks = new();
        readonly IShuffler shuffler;

        public DeckSorter(IShuffler shuffler)
        {
            this.shuffler = shuffler;
        }

        public void CreateCardDeck(string name)
        {
            if (decks.ContainsKey(name))
                throw new Exception("Колода с таким именем уже существует");

            Deck deck = new Deck(shuffler);
            deck.FillWithCards();
            decks.Add(name, deck);
        }

        public void DeleteCardDeck(string name)
        {
            if (!decks.ContainsKey(name))
                throw new Exception("Колоды с таким именем не существует");

            decks.Remove(name);
        }

        public Deck GetCardDeck(string name)
        {
            if (!decks.ContainsKey(name))
                throw new Exception("Колоды с таким именем не существует");

            return decks[name];
        }

        public List<string> GetDecksNames()
        {
            return decks.Keys.ToList();
        }

        public void ShuffleCardDeck(string name)
        {
            if (!decks.ContainsKey(name))
                throw new Exception("Колоды с таким именем не существует");

            decks[name].ShuffleDeck();
        }
        



        public override string ToString()
        {
            return $"Total decks of cards: {decks.Count}";
        }
    }
}
