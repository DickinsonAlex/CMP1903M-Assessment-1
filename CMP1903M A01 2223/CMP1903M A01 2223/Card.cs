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
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value >= 1 && value <= 13)
                {
                    _value = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value supplied");
                }
            }
        }
        private int _suit;
        public int Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _suit = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value supplied");
                }
            }
        }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public override String ToString()
        {

            String[] Suits = new String[4] { "Spades", "Hearts", "Clubs", "Diamonds" };
            String[] Values = new String[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            return Values[Value - 1] + " of " + Suits[Suit - 1];
        }
    }
}
