namespace DecksSorter
{
    public class Card
    {
        public Cards card;
        public Suits suit;

        public Card(Cards card, Suits suit)
        {
            this.card = card;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"Card: {card}, Suit: {suit}";
        }
    }
}
