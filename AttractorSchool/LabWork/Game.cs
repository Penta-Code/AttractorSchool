namespace LabWork
{
    internal class Game
    {
        public void ShowResult(Card[] cards)
        {
            int pairCounter = 0;
            int tripleCoutner = 0;
            int pokerCounter = 0;
            int flushCounter = 0;

            string ranks = "2345678910JQKA";
            int[] RanksCounter = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            string suits = "♠♥♦♣";
            int[] SuitsCounter = { 1, 1, 1, 1 };

            //Check for rank and suit equality and increase array elemnt by index of equal ranks or suits
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 1; j <= cards.Length - 1; j++)
                {
                    if (i == j || j < i) continue;

                    if (cards[i].Rank.Equals(cards[j].Rank))
                    {
                        int index = ranks.IndexOf(cards[i].Rank);
                        RanksCounter[index]++;
                    }

                    if (cards[i].Suit.Equals(cards[j].Suit))
                    {
                        int index = suits.IndexOf(cards[i].Suit);
                        SuitsCounter[index]++;
                    }
                }
            }

            //Count rank combinations
            foreach (var item in RanksCounter)
            {
                if (item == 2)
                {
                    pairCounter++;
                }

                if (item == 3)
                {
                    tripleCoutner++;
                }

                if (item == 4)
                {
                    pokerCounter++;
                }
            }

            //Check for flush combination
            foreach (var item in SuitsCounter)
            {
                if (item == 5)
                {
                    flushCounter++;
                }
            }

            //Show result based on rank and suit counters
            if (flushCounter == 1)
            {
                Console.WriteLine("Ваша комбинация: Флэш!\n5 карт одной масти");
            }
            else if (tripleCoutner == 1 && pairCounter == 1)
            {
                Console.WriteLine("Ваша комбинация: Фулл-хаус!\n1 тройка + 1 пара");
            }
            else if (pokerCounter == 1)
            {
                Console.WriteLine("Ваша комбинация: Покер!\n4 карты одного ранга");
            }
            else if (pairCounter == 2)
            {
                Console.WriteLine("Ваша комбинация: Две пары!\n2 карты одного ранга + еще 2 одинаковые карты другого ранга");
            }
            else if (tripleCoutner == 1)
            {
                Console.WriteLine("Ваша комбинация: Тройка!\n3 карты одного ранга");
            }
            else if (pairCounter == 1)
            {
                Console.WriteLine("Ваша комбинация: Одна пара!\n2 карты одного ранга");
            }
            else
            {
                Console.WriteLine("Комбинаций нет!");
            }
        }


        public int[] InputProcessing()
        {
            int index = 0;
            Console.WriteLine("Через пробел введите номера карт (от 1 до 5), которые вы хотите заменить.\nНапример, \"1 3 4\" заменят 1, 3 и 4 карты соответственно\nКоличество карт не должно быть больше 5!");
            var input = Console.ReadLine();

            while (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input) || input.Length > 5)
            {
                Console.WriteLine("Через пробел введите номера карт (от 1 до 5), которые вы хотите заменить.\nНапример, \"1 3 4\" заменят 1, 3 и 4 карты соответственно\nКоличество карт не должно быть больше 5!");
                input = Console.ReadLine();
            }

            var text = input.Split(' ');

            int[] cardIndex = new int[text.Length];

            for (int i = 0; i < cardIndex.Length; i++)
            {
                if (int.TryParse(text[i], out index) && index <= 5)
                {
                    cardIndex[i] = --index;
                }
                else
                {
                    cardIndex[i] = -1;
                    Console.WriteLine("Незвестный индекс карты! Карта не будет заменена");
                }
            }

            return cardIndex;
        }
    }
}