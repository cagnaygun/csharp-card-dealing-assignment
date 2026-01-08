using System;
using System.Net.NetworkInformation;
using ConsoleCards;

// IMPORTANT: Only add code in the section
// indicated below. The code I've provided
// makes your solution work with the 
// automated grader on Coursera

/// <summary>
/// Programming Assignment 3
/// </summary>
class Program
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    /// <param name="args">command-line args</param>
    static void Main(string[] args)
    {
        // loop while there's more input
        string input = Console.ReadLine();
        while (input[0] != 'q')
        {
            // create deck (DO NOT SHUFFLE)
            Deck deck = new Deck();

            // create hands
            System.Collections.Generic.List<Card> player1 = new System.Collections.Generic.List<Card>();
            System.Collections.Generic.List<Card> player2 = new System.Collections.Generic.List<Card>();
            System.Collections.Generic.List<Card> player3 = new System.Collections.Generic.List<Card>();
            System.Collections.Generic.List<Card> player4 = new System.Collections.Generic.List<Card>();

            // first round
            player1.Add(deck.TakeTopCard()); // King
            player2.Add(deck.TakeTopCard()); // Queen
            player3.Add(deck.TakeTopCard()); // Five
            player4.Add(deck.TakeTopCard()); // Four

            // second round
            player1.Add(deck.TakeTopCard()); // Nine
            player2.Add(deck.TakeTopCard()); // Eight
            player3.Add(deck.TakeTopCard()); // Jack
            player4.Add(deck.TakeTopCard()); // Ten

            // remaining cards:
            // first give ALL remaining cards to player3, then to player4
            player3.Add(deck.TakeTopCard()); // Seven
            player4.Add(deck.TakeTopCard()); // Six

            // print player 1
            for (int i = 0; i < player1.Count; i++)
            {
                player1[i].FlipOver();
                Console.WriteLine(player1[i].Rank + "," + player1[i].Suit);
            }

            // print player 2
            for (int i = 0; i < player2.Count; i++)
            {
                player2[i].FlipOver();
                Console.WriteLine(player2[i].Rank + "," + player2[i].Suit);
            }

            // print player 3 cards in required order: Five, Jack, Seven
            player3[2].FlipOver();
            Console.WriteLine(player3[2].Rank + "," + player3[2].Suit);

            player3[0].FlipOver();
            Console.WriteLine(player3[0].Rank + "," + player3[0].Suit);

            player3[1].FlipOver();
            Console.WriteLine(player3[1].Rank + "," + player3[1].Suit);


            // print player 4 cards in required order: Four, Ten, Six
            player4[2].FlipOver();
            Console.WriteLine(player4[2].Rank + "," + player4[2].Suit);

            player4[0].FlipOver();
            Console.WriteLine(player4[0].Rank + "," + player4[0].Suit);

            player4[1].FlipOver();
            Console.WriteLine(player4[1].Rank + "," + player4[1].Suit);


            // Don't add or modify any code below
            // this comment
            input = Console.ReadLine();
        }
    }
}