using System;
/* HOMEWORK 3 part 2: Blackjack Using Emuns and Arrays
 * Name: Kayla Cromer
 * 
 * CMIS 1301
 * 
 * Summer 2021
 * 
 * Requirements Met:
 *1. commented note with all revelant information
 *CLASSES: Program
 */
namespace Cromer_Kayla_hw3_pt2
{
    /* CLASS: Program
  * STATIC PRIVATE FIELDS:
  * STATIC PUBLIC FIELDS:
  * NON-STATIC PRIVATE FIELDS:
  * NON-STATIC PUBLIC FIELDS:
  * STATIC PRIVATE METHODS:
  * STATIC PUBLIC METHODS:
  * NON-STATIC PRIVATE METHODS:
  * NON-STATIC PUBLIC METHODS:
  * DESCRIPTION:
  * 
  * VERSION/DATE:
  */
    public enum Suit { S, C, D, H };

    public enum Rank { _A, _2, _3, _4, _5, _6, _7, _8, _9, _10, _J, _Q, _K };
    class Program
    {
        static public Deck manyThings;

        static string input;

        /* METHOD: Main()
         * Params: none
         * returns: return statement if user gives invalid input. returns user to the beginning.
         * CLASS SCOPE EFFECTS: switch(input)
         * CALLED FUNCTIONS: Console.WriteLine(<intro and press Y to shuffle deck>), switch(input)
         * 
         * DESCRIPTION: Console gives line of introduction of my name and that a deck has been created for the user to shuffle. User will input Y and is also 
         * set if user inputs y since this will not be case sensitive as long as Y or y is input. If user inputs anything other than Y or y, then the console will 
         * output "Invalid. Please press Y to shuffle the deck" then returning the user to the beginning to try again instead of having to close and rerun the program.
         * 
         * VERSION/DATE: 1.0 / Jul 15
         */
        static void Main()
        {
            Console.WriteLine("Kayla Cromer has created a deck for you to shuffle. \n Press Y to shuffle the deck and see the result.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                    break;
                case "y":
                    break;
                default:
                    Console.WriteLine("Invalid. Please press y to shuffle the deck");
                    Program.Main();
                    return; //returns user to the start if input is not "Y" || "y"
            }
            manyThings = new Deck();

            //shuffles instance of deck
            manyThings.Shuffle();

            //prints deck 
            manyThings.PrintDeck();
        }
    }
}
