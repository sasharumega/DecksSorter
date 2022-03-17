using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecksSorter
{
    public class Deck
    {
        public List<Card> cards = new();
        private readonly IShuffler shuffler;
        public readonly string name;

        public Deck(IShuffler method, string name)
        {
            this.name = name;
            shuffler = method;
        }

        public void ShuffleDeck()
        {
            cards = shuffler.GetShuffledItems(cards);
        }

        public void FillWithCards()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
                foreach (Cards card in Enum.GetValues(typeof(Cards)))
                    cards.Add(new Card(card, suit));
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"Deck size: {cards.Count}\nCards:");
            foreach (var card in cards)
                sb.Append($"\n{card}");

            return sb.ToString();
        }
    }
}
