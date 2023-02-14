using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            //Create a new pack of cards
            Pack pack = new Pack();
            
            //Ask the user how many cards they want to deal
            Console.WriteLine("How many cards do you want to deal?");
            
            int numCards = 0;
            bool success = false;
            while (numCards < 1 || numCards > 52) //Error Trapping the input
            {
                try //Error trapping to see if an integer is entered
                {
                    numCards = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 52");
                    numCards = 0;
                }
                finally
                {
                    if (success && (numCards < 1 || numCards > 52)) //Error trapping to see if the number is between 1 and 52
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 52");
                    }
                    success = false;
                }
            }

            //Ask the user what shuffle to use
            Console.WriteLine("Which shuffle do you want to use? (1) Fisher-Yates, (2) Riffle, (3) None ");
            int shuffle = 0;
            while (shuffle < 1 || shuffle > 3) //Error Trapping the input
            {
                try //Error trapping to see if an integer is entered
                {
                    shuffle = Convert.ToInt32(Console.ReadLine());
                    success = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    shuffle = 0;
                }
                finally
                {
                    if (success && (shuffle < 1 || shuffle > 3)) //Error trapping to see if the number is between 1 and 3
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                    success = false;
                }
            }
            
            //Shuffle the pack
            pack.shuffleCardPack(shuffle);

            //Deal the cards and add them to dealt cards
            List<Card> dealtCards = Pack.dealCards(numCards);

            //Print the dealt cards
            string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" }; //This is just to make the output look nicer
            string[] values = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            
            Console.WriteLine("Dealt cards:");
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(values[card.Value -1] + " of " + suits[card.Suit-1]);
            }
        }
    }
}
