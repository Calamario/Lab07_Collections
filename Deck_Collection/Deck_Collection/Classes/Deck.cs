using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Deck_Collection.Classes
{
    public class Deck<T> : IEnumerable
    {
        public T[] cards = new T[5];

        private int count;

        /// <summary>
        /// Adds a card to the array
        /// </summary>
        /// <param name="card"> Type T card object </param>
        public void Add(T card)
        {
            // make the array bigger if the array is full
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            // add the card obj into the array
            cards[count++] = card;
        }

        /// <summary>
        /// Logic Incomplete
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard(T card)
        {

        }

        /// <summary>
        /// Removes all the cards in the array
        /// </summary>
        public void RemoveExpensive()
        {
            Array.Resize(ref cards, 0);
            Array.Resize(ref cards, 5);
        }

        /// <summary>
        /// Shuffles the current list of cards
        /// </summary>
        public void Shuffle()
        {
            Random rng = new Random();
            int cardNum = cards.Length;
            while (cardNum > 1)
            {
                //Decrements the total number of cards so that each position will change places with another
                int randomNum = rng.Next(0, cardNum--);
                T temp = cards[cardNum];
                cards[cardNum] = cards[randomNum];
                cards[randomNum] = temp;
            }

        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        // magic 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
