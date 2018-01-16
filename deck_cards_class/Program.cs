// Program that creates Classes Card, Deck, and Player with methods and properties;
using System;
using System.Collections.Generic;

namespace deck_cards_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Card first = new Card("word", "word2", 50);
            System.Console.WriteLine(first.stringVal);
            System.Console.WriteLine(first.suit);
            System.Console.WriteLine(first.val);
            Deck deck1 = new Deck();
            deck1.CreateDeck();
            object thing = deck1.cards[10];
}
}
}