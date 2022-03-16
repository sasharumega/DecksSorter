using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecksSorter
{
    public class Deck
    {
        public List<Card> cards = new();
        readonly IShuffler shuffler;

        public Deck(IShuffler method)
        {
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
            StringBuilder sb = new StringBuilder($"Deck size: {cards.Count()}\nCards:");
            foreach (Card card in cards)
                sb.Append($"\n{card}");

            return sb.ToString();
        }
    }
}
