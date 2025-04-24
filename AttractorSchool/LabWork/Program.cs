namespace LabWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Deck deck = new Deck();
            Hand hand = new Hand();
            Game game = new Game();

            hand.FillHand(deck.GetFullHand());
            Console.WriteLine(hand.ToString());

            Console.WriteLine("Хотите заменить любые карты из имеющихся?\nВведите Y чтобы заменить\nНажмите Enter чтобы продолжить");
            var input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                var index = game.InputProcessing();

                for (int i = 0; i < index.Length; i++)
                {
                    if (index[i] >= 0)
                    {
                        hand.ChangeCard(index[i], deck.GetCard());
                    }
                }

                Console.WriteLine(hand.ToString());
            }

            game.ShowResult(hand.MyHand);
        }
    }
}