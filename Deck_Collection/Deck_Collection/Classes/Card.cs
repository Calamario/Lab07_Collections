using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Collection.Classes
{
    public class Card
    {

        public Value Value { get; set; }

        public Suit Suit { get; set; }
    }

    public enum Value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Heart,
        Spade,
        Club,
        Diamond
    }
}
