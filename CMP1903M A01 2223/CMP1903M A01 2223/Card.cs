using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        
        private int value;
        private int suit;

        public Card(int Value, int Suit)
        {
            value = Value;
            suit = Suit;
        }

        public int Value { get { return value; } }
        public int Suit { get { return suit; } }
    }
}
