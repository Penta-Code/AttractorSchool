using System.ComponentModel.DataAnnotations;

namespace LabWork
{
    internal class Program
    {

        //"\u2660"; "\u2665"; "\u2666"; "\u2663";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Card[] userCards = new Card[5];
            Deck deck = new Deck();
            Hand hand = new Hand();

            for (int i = 0; i < hand.MyHand.Length; i++)
            {
                userCards[i] = deck.GetCard();
            }

            hand.PopulateHand(userCards);

            Console.WriteLine(hand.ToString());


            Console.WriteLine("Через пробел введите номера карт, которые вы хотите заменить.\nНапример, \"0 3 4\" заменят 0, 3 и 4 карты соответственно");
            
            var input = Console.ReadLine().Split(' ');

            int[] cardIndex = new int[input.Length];

            for (int i = 0; i < cardIndex.Length; i++)
            {
                cardIndex[i] = Convert.ToInt32(input[i]);
            }

            for (int i = 0; i < cardIndex.Length; i++)
            {
                hand.ChangeCard(cardIndex[i], deck.GetCard());
            }

            Console.WriteLine(hand.ToString());
        }
    }
}