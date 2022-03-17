using DecksSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecksSorter
{
    public class DeckSorter : IDeckSorter
    {
        
        private readonly IShuffler shuffler;
        private readonly IDeckDatabase deckDatabase;

        public DeckSorter(IShuffler shuffler, IDeckDatabase deckDatabase)
        {
            this.shuffler = shuffler;
            this.deckDatabase = deckDatabase;
        }

        public void CreateCardDeck(string name)
        {
            var deck = new Deck(shuffler, name);
            deck.FillWithCards();
            deckDatabase.AddDeck(deck);
        }

        public void DeleteCardDeck(string name)
        {
            deckDatabase.DeleteDeck(name);
        }

        public Deck GetCardDeck(string name)
        {
            return deckDatabase.GetDeck(name);
        }

        public List<string> GetDecksNames()
        {
            return deckDatabase.GetAllDecks().Select(d => d.name).ToList();
        }

        public void ShuffleCardDeck(string name)
        {
            deckDatabase.GetDeck(name).ShuffleDeck();
        }

        public override string ToString()
        {
            return $"Total decks of cards: {deckDatabase.GetAllDecks().Count}";
        }
    }
}
