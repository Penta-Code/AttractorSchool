using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class Deck
    {
        private static string[] _ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; //Length = 13
        private static string[] _suits = { "\u2660", "\u2665", "\u2666", "\u2663" };

        public Card[] MyDeck { get; private set; }

        public Deck()
        {
            MyDeck = NewDeck();
        }

        private Card[] NewDeck()
        {
            Card[] myDeck = new Card[52];
            int deckCounter = 0;
            int rankCounter = 0;
            int suitCounter = 0;

            while (deckCounter < myDeck.Length)
            {
                myDeck[deckCounter] = new Card(_ranks[rankCounter], _suits[suitCounter]);

                if (rankCounter == _ranks.Length - 1)
                {
                    rankCounter = 0;
                    suitCounter++;
                }
                else
                    rankCounter++;

                deckCounter++;
            }

            return myDeck;
        }

        public Card GetCard()
        {
            Random rnd = new Random();
            int cardIndex = rnd.Next(0, MyDeck.Length);
            
            while (MyDeck[cardIndex] == null)
            {
                cardIndex = rnd.Next(0, MyDeck.Length);
            }

            Card card = MyDeck[cardIndex];
            MyDeck[cardIndex] = null;

            return card;
        }



        public override string ToString()
        {
            return $"{MyDeck.Length}";
        }
    }
}