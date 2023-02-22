using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int num = 1; num <= 13; num++)
                {
                    pack.Add(new Card(num, suit));
                }
            }
        }

        public void riffleShuffle()
        {
            //Riffle shuffle the pack
            Random rnd = new Random();
            int length = pack.Count;
            int k = rnd.Next(length / 2);
            int l = rnd.Next(length / 2);
            while (length > 1)
            {
                length--;
                Card value = pack[k];
                pack[k] = pack[l];
                pack[l] = value;
            }
        }

        public void fisherYatesShuffle()
        {
            //Fisher-Yates shuffle the pack
            Random rnd = new Random();
            int length = pack.Count;
            while (length > 1)
            {
                length--;
                int k = rnd.Next(length + 1);
                Card value = pack[k];
                pack[k] = pack[length];
                pack[length] = value;
            }
        }
        public void shuffleCardPack(int typeOfShuffle)
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
