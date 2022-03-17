using DecksSorter.DeckDatabases;
using DecksSorter.Shufflers;
using System;

namespace DecksSorter
{
    class Program
    {
        static void Main()
        {
            var sorter = new DeckSorter(new RealShuffler(), new MemoryBasedDeckDatabase());
            sorter.CreateCardDeck("test_deck");
            sorter.ShuffleCardDeck("test_deck");
            Console.WriteLine(sorter.GetCardDeck("test_deck"));

            sorter.DeleteCardDeck("test_deck");

            sorter.CreateCardDeck("test_deck");
            sorter.ShuffleCardDeck("test_deck");
            Console.WriteLine(sorter.GetCardDeck("test_deck"));

            sorter.CreateCardDeck("test_deck2");
            Console.WriteLine(sorter.GetCardDeck("test_deck2"));

            //sorter.DeleteCardDeck("qfgh397gh389h9fq");

            Console.ReadKey();
        }
    }
}
