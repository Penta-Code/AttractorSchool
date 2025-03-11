namespace SecondMonthExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---          Start game          ---\nPredict the points number (2..12)");

            var userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"User predicted: {userInput}");

            int dice1Side = RollTheDice();
            int dice2Side = RollTheDice();

            int diceSumm = dice1Side + dice2Side;

            PrintDice(dice1Side);
            PrintDice(dice2Side);
            Console.WriteLine($"On the dice fell {diceSumm} points.");
        }

        public static void PrintDice(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("-----------\n|         |\n|    #    |\n|         |\n-----------");
                    break;
                case 2:
                    Console.WriteLine("----------\n|       #|\n|        |\n|#       |\n----------");
                    break;
                case 3:
                    Console.WriteLine("-----------\n|        #|\n|    #    |\n|#        |\n-----------");
                    break;
                case 4:
                    Console.WriteLine("---------\n| #   # |\n|       |\n| #   # |\n---------");
                    break;
                case 5:
                    Console.WriteLine("---------\n| #   # |\n|   #   |\n| #   # |\n---------");
                    break;
                case 6:
                    Console.WriteLine("---------\n| # # # |\n|       |\n| # # # |\n---------");
                    break;
            }
        }

        public static int RollTheDice()
        {
            var rnd = new Random();

            return rnd.Next(1, 7);
        }
    }
}