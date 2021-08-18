using System;

namespace Deck
{
    /* CLASS: Card
   * STATIC PRIVATE FIELDS: 
   * STATIC PUBLIC FIELDS:
   * NON-STATIC PRIVATE FIELDS: 
   * NON-STATIC PUBLIC FIELDS: Value,
   * STATIC PRIVATE METHODS:
   * STATIC PUBLIC METHODS:
   * NON-STATIC PRIVATE METHODS:
   * NON-STATIC PUBLIC METHODS:
   * DESCRIPTION: public int Value is calling the value (# 
   * 
   * VERSION/DATE:
   */
    class Card
    {
        public int value;

        //added Suit, Rank and is_used as fields
        public Suit sut;
        public Rank rnk;
        public bool isUsed = false;

        /* Function: Card constructor
         * params: none
         * returns: card object
         * class scope effects: sut and rnk are given values
         * at instantiation
         * Called functions: Shuffle(), Console.WriteLine()
         * 
         * Description: instantiates the Card object
         * 
         * version/date: 1.0 / 7.18.2021
        */

        public Card()
        {
            //load default
            //value = 0;
        }

        public Card(Suit s, Rank r)
        {
            sut = s;
            rnk = r;
        }
    }
}
