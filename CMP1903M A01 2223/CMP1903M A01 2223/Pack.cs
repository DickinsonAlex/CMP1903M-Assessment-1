using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialises the card pack
            pack = new List<Card>();
            for (int i = 0; i < 52; i++) //Creates 52 cards, modulus is the value and devide is the suit
            {
                pack.Add(new Card((i % 13) + 1, (i / 13) + 1));
            }
        }

        public void riffleShuffle()
        {
            int mid = (int)Math.Floor((decimal) pack.Count / 2); //Find mid point
            List<Card> first = pack.Take(mid).ToList(); //First half
            List<Card> second = pack.Skip(mid).Take(mid).ToList(); //Second half
            List<Card> shuffled = new List<Card>(); 
            for (int i = 0; i < mid; i++) //Alternate adding left and right half cards to the new list
            {
                shuffled.Add(first[i]);
                shuffled.Add(second[i]);
            }
            pack = shuffled;
        }

        public void fisherYatesShuffle()
        {
            //Fisher-Yates shuffle the pack
            Random rnd = new Random();
            for (int i = 0; i < pack.Count; i++)
            {
                int randIndex = rnd.Next(i, pack.Count);
                Card tempValue = pack[randIndex];
                pack[randIndex] = pack[i];
                pack[i] = tempValue;
            }
        }
        public void shuffleCardPack(int typeOfShuffle) //Uses abstraction to break down the shuffle code into smaller methods
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle)
            {
                case 1:
                    //Fisher-Yates Shuffle
                    fisherYatesShuffle();
                    break;
                case 2:
                    //Riffle Shuffle
                    riffleShuffle();
                    break;
                case 3:
                    //No Shuffle
                    break;
            }
        }
        public static Card deal()
        {
            //Deals a card from the pack
            Card dealtCard = pack[pack.Count - 1];
            pack.RemoveAt(pack.Count - 1);
            return dealtCard;
        }
        public static List<Card> dealCards(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealtCards = new List<Card>();
            for (int i = 1; i <= amount; i++)
            {
                dealtCards.Add(deal());
            }
            return dealtCards;
        }
    }
}
