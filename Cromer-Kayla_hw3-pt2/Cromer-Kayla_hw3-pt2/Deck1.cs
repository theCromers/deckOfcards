namespace Cromer_Kayla_hw3_pt2
{
    using System;
    public class Deck
    {
        //decalres an empty 4 x 13 array of cards
        public Card[,] shuffledDeck = new Card[4, 13];

        //declaring and initializing 4 rows x 13 cols 2d array with unique card values
        public Card[,] masterOrderedDeck = new Card[4, 13]
        {
            //row 0 for 13 cols - Spades
            {new Card(Suit.S, Rank._A), new Card(Suit.S, Rank._2), new Card(Suit.S, Rank._3),
                new Card(Suit.S, Rank._4), new Card(Suit.S, Rank._5), new Card(Suit.S, Rank._6),
                new Card(Suit.S, Rank._7), new Card(Suit.S, Rank._8), new Card(Suit.S, Rank._9),
                new Card(Suit.S, Rank._10), new Card(Suit.S, Rank._J), new Card(Suit.S, Rank._Q), new Card(Suit.S, Rank._K)},

            //row 1 for 13 cols - Clubs
            {new Card(Suit.C, Rank._A), new Card(Suit.C, Rank._2), new Card(Suit.C, Rank._3),
                new Card(Suit.C, Rank._4), new Card(Suit.C, Rank._5), new Card(Suit.C, Rank._6),
                new Card(Suit.C, Rank._7), new Card(Suit.C, Rank._8), new Card(Suit.C, Rank._9),
                new Card(Suit.C, Rank._10), new Card(Suit.C, Rank._J), new Card(Suit.C, Rank._Q), new Card(Suit.C, Rank._K)},

            //row 2 for 13 cols - Diamonds
            {new Card(Suit.D, Rank._A), new Card(Suit.D, Rank._2), new Card(Suit.D, Rank._3),
                new Card(Suit.D, Rank._4), new Card(Suit.D, Rank._5), new Card(Suit.D, Rank._6),
                new Card(Suit.D, Rank._7), new Card(Suit.D, Rank._8), new Card(Suit.D, Rank._9),
                new Card(Suit.D, Rank._10), new Card(Suit.D, Rank._J), new Card(Suit.D, Rank._Q), new Card(Suit.D, Rank._K)},

            //row 3 for 13 cols - Hearts
            {new Card(Suit.H, Rank._A), new Card(Suit.H, Rank._2), new Card(Suit.H, Rank._3),
                new Card(Suit.H, Rank._4), new Card(Suit.H, Rank._5), new Card(Suit.H, Rank._6),
                new Card(Suit.H, Rank._7), new Card(Suit.H, Rank._8), new Card(Suit.H, Rank._9),
                new Card(Suit.H, Rank._10), new Card(Suit.H, Rank._J), new Card(Suit.H, Rank._Q), new Card(Suit.H, Rank._K)}
        };

        public void PrintDeck()
        {
            //loop demo of shuffledDeck, 
            //printing out elements based on interator (i) ascending
            Console.WriteLine("The current shuffled deck.");
            Console.WriteLine("---------");

            for (int i = 0; i <= 51; i++)
            {
                Console.WriteLine(i + "[" + (int)(i / 13) + "," + i % 13 + "] "
                    + " Suit: " + shuffledDeck[(int)(i / 13), i % 13].sut
                    + " Rank: " + shuffledDeck[(int)i / 13, i
                    % 13.rnk]);

            }
            Console.WriteLine("-----");
        }
    }
}