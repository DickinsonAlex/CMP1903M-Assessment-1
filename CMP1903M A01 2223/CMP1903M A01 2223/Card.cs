namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4

        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        //Add a set method with validation
        public void setValue(int value)
        {
            if (value >= 1 && value <= 13)
            {
                Value = value;
            }
        }

        //Set suit method with validation
        public void setSuit(int suit)
        {
            if (suit >= 1 && suit <= 4)
            {
                Suit = suit;
            }
        }
    }
}
