using System;
using ConsoleCards;

namespace Exercise11
{
    /// <summary>
    /// Exercise 11
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 11
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card[] hand = new Card[5];
            deck.Shuffle();
            hand[0] = deck.TakeTopCard();
            hand[0].FlipOver();
            hand[0].Print();
        }
    }
}
