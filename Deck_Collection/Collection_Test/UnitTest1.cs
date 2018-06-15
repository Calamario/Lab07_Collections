using System;
using Xunit;
using Deck_Collection.Classes;

namespace Collection_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanACardBeAdded()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Deck<Card> myCards = new Deck<Card> { card };
            myCards.Add(card2);

            Assert.Equal(card2, myCards.cards[1]);
        }

        [Fact]
        public void CanMoreCardsBeAdded()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Queen
            };

            Deck<Card> myCards = new Deck<Card> { card };
            myCards.Add(card2);
            myCards.Add(card3);

            Assert.Equal(card3, myCards.cards[2]);
        }

        [Theory]
        [InlineData(Suit.Diamond, Suit.Diamond)]
        [InlineData(Suit.Spade, Suit.Spade)]
        public void CanChangePropertyOfCard(Suit input, Suit expected)
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            card.Suit = input;

            Assert.Equal(expected, card.Suit);
        }

        [Fact]
        public void CanCardsBeShuffled()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Club,
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

            Deck<Card> myCards = new Deck<Card>
            {  
                card, card2, card3, card4, card5,
                card6, card7, card8, card9, card10
            };

            Deck<Card> copyCards = new Deck<Card>
            {
                card, card2, card3, card4, card5,
                card6, card7, card8, card9, card10
            };

            copyCards.Shuffle();

            Assert.NotEqual(myCards, copyCards);
        }

        [Fact]
        public void CanIRemoveCard()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Queen
            };

            Deck<Card> myCards = new Deck<Card> { card, card2, card3 };

            Assert.True(myCards.RemoveCard(card));
        }

        [Fact]
        public void CanIRemoveLastCard()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Queen
            };

            Deck<Card> myCards = new Deck<Card> { card, card2, card3 };

            Assert.True(myCards.RemoveCard(card3));

        }

        [Fact]
        public void ReturnFalseIRemoveCardThatDoesNotExist()
        {
            Card card = new Card
            {
                Suit = Suit.Heart,
                Value = Value.Ace
            };

            Card card2 = new Card
            {
                Suit = Suit.Spade,
                Value = Value.King
            };

            Card card3 = new Card
            {
                Suit = Suit.Club,
                Value = Value.Queen
            };

            Card card4 = new Card
            {
                Suit = Suit.Diamond,
                Value = Value.Five
            };

            Deck<Card> myCards = new Deck <Card> { card, card2, card3 };

            Assert.False(myCards.RemoveCard(card4));

        }
    }
}
