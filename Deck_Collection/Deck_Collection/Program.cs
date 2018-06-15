using System;
using Deck_Collection.Classes;

namespace Deck_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deal();
        }

        static void Deal()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Heart,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Queen
            };

            Card card4 = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Jack
            };

            Card card5 = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ten
            };

            Card card6 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.Ace
            };

            Card card7 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card8 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.Queen
            };

            Card card9 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.Jack
            };

            Card card10 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.Ten
            };

            Card card11 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.Ace
            };

            Card card12 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.King
            };

            Card card13 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.Queen
            };

            Card card14 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.Jack
            };

            Card card15 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.Ten
            };

            Card card16 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Ace
            };

            Card card17 = new Card
            {
                Suit = Suit.Club,
                Value = Value.King
            };

            Card card18 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Queen
            };

            Card card19 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Jack
            };

            Card card20 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Ten
            };

            //initialize the first 15 cards
            Deck<Card> myCards = new Deck<Card>
            {
                card, card2, card3, card4, card5,
                card6, card7, card8, card9, card10,
                card11, card12, card13, card14, card15
            };

            // Show that my add methods work for the last 5 cards
            myCards.Add(card16);
            myCards.Add(card17);
            myCards.Add(card18);
            myCards.Add(card19);
            myCards.Add(card20);

            //displays my cards
            DisplayCards(myCards);
            Console.WriteLine();
            Console.WriteLine("Hit Enter to Shuffle");
            Console.ReadLine();

            //Shuffling of Cards
             myCards.Shuffle();

            DisplayCards(myCards);
            Console.ReadLine();

        }

        static void DisplayCards(Deck<Card> myCards)
        {
            foreach (var cardItem in myCards)
                Console.WriteLine($"{cardItem.Value} of {cardItem.Suit}");
        }
    }
}
