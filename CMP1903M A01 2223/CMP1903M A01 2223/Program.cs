using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new pack of cards
            Pack pack = new Pack();
            
            //Ask the user how many cards they want to deal
            Console.WriteLine("How many cards do you want to deal?");
            
            int numCards = 0;
            while (numCards < 1 || numCards > 52) //Error Trapping the input
            {
                try //Error trapping to see if a number is entered
                {
                    numCards = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number between 1 and 52");
                    numCards = 0;
                }
            }

            //Ask the user what shuffle to use
            Console.WriteLine("Which shuffle do you want to use? (1) Overhand, (2) Riffle, (3) Fisher-Yates");
            int shuffle = 0;
            while (shuffle < 1 || shuffle > 3) //Error Trapping the input
            {
                try //Error trapping to see if a number is entered
                {
                    shuffle = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    shuffle = 0;
                }
            }
            
            //Shuffle the pack
            pack.shuffleCardPack(shuffle);

            //Deal the cards and add them to dealt cards
            List<Card> dealtCards = Pack.dealCards(numCards, pack);

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
