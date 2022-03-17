# Сортировщик колод карт
## Что умеет?

* Создание/получение/удаление колоды (по имени)
* Перетасовка карт думая способами: полностью случайно и если бы человек менял местами 2 случайные карты много раз

## Интерфейсы

* IShuffler - для создания перетасовок
* IDeckSorter - для создания сортировщиков
* IDeckDatabase - для создания хранилищ карт (в будущем можно реализовать подключение к базе данных, сейчас там только хранение в памяти)

## Быстрый старт

```c#
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
```
