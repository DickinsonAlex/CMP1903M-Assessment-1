using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;
        
        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    pack.Add(new Card(j, i));
                }
            }
        }
        
        public void riffleShuffle()
        {
            //Riffle shuffle the pack
            Random rnd = new Random();
            int n = pack.Count;
            int k = rnd.Next(n / 2);
            int l = rnd.Next(n / 2);
            while (n > 1)
            {
                n--;
                Card value = pack[k];
                pack[k] = pack[l];
                pack[l] = value;
            }
        }
        
        public void fisherYatesShuffle()
        {
            //Fisher-Yates shuffle the pack
            Random rnd = new Random();
            int n = pack.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = pack[k];
                pack[k] = pack[n];
                pack[n] = value;
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
        public static Card deal(List<Card> pack)
        {
            //Deals a card from the pack
            Card dealtCard = pack[pack.Count - 1];
            pack.RemoveAt(pack.Count - 1);
            return dealtCard;
        }
        public static List<Card> dealCards(int amount, Pack newPack)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealtCards = new List<Card>();
            for (int i = 1; i <= amount; i++)
            {
                dealtCards.Add(deal(newPack.pack));
            }
            return dealtCards;
        }
    }
}
