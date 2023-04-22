using System;
using System.Threading;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        private int _value;
        public int Value //Value is encapsulated using getters and setters
        {
            get
            {
                return _value; //Return the value of the card
            }
            set
            {
                if (value >= 1 && value <= 13) //Out of range checking
                {
                    _value = value; 
                }
                else
                {
                    throw new ArgumentException("Invalid value supplied"); //Error Prompt
                }
            }
        }
        private int _suit;
        public int Suit //Suit is encapsulated using getters and setters
        {
            get
            {
                return _suit;
            }
            set
            {
                if (value >= 1 && value <= 4) //Out of range checking
                {
                    _suit = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value supplied"); //Error Prompt
                }
            }
        }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public override String ToString() //This is an additional method to those provided by the base code
        {

            String[] Suits = new String[4] { "Spades", "Hearts", "Clubs", "Diamonds" };
            String[] Values = new String[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            return Values[Value - 1] + " of " + Suits[Suit - 1];
        }
    }
}
