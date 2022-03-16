using DecksSorter.Shufflers;
using System;

namespace DecksSorter
{
    class Program
    {
        static void Main()
        {
            DeckSorter sorter = new DeckSorter(new RealShuffler());
            sorter.CreateCardDeck("test_deck");
            sorter.ShuffleCardDeck("test_deck");
            Console.WriteLine(sorter.GetCardDeck("test_deck"));
            Console.ReadKey();
        }
    }
}
