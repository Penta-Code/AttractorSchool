using System;

namespace SecondMonthExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int userInput;

            int[] userPredictions = new int[3];
            int[] userDice = new int[3];
            int[] userResult = new int[3];

            int[] compPredictions = new int[3];
            int[] compDice = new int[3];
            int[] compResult = new int[3];

            bool play = true;
            string answer = "";

            Console.WriteLine("---          Start game          ---");

            while (play)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write("Predict the points number(2..12): ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out userInput))
                    {
                        Console.Write("Error! Input must be a number from 2 to 12\n");
                        break;
                    }

                    if (userInput < 2 || userInput > 12)
                    {
                        Console.Write("Error! Input must be more than 2 and less than 12\n");
                        break;
                    }
                    
                    Console.WriteLine($"User rolls the dice:");
                    int dice1Side = RollTheDice();
                    int dice2Side = RollTheDice();

                    int diceSumm = dice1Side + dice2Side;
                    int userPoints = diceSumm - Math.Abs(diceSumm - userInput) * 2;

                    PrintDice(dice1Side);
                    PrintDice(dice2Side);
                    Console.WriteLine($"On the dice fell {diceSumm} points.");
                    Console.WriteLine($"Result is {diceSumm} - abs({diceSumm} - {userInput}) * 2: {userPoints} points");
                    //Collect data for result table
                    userPredictions[i] = userInput;
                    userDice[i] = diceSumm;
                    userResult[i] = userPoints;

                    //Computer part
                    var compPredict = rnd.Next(2, 12);
                    Console.WriteLine($"\nComputer predicted {compPredict} points");

                    Console.WriteLine($"Computer rolls the dice:");
                    dice1Side = RollTheDice();
                    dice2Side = RollTheDice();

                    int compDiceSumm = dice1Side + dice2Side;
                    int compPoints = compDiceSumm - Math.Abs(compDiceSumm - compPredict) * 2;

                    PrintDice(dice1Side);
                    PrintDice(dice2Side);
                    Console.WriteLine($"On the dice fell {compDiceSumm} points.");
                    Console.WriteLine($"Result is {compDiceSumm} - abs({compDiceSumm} - {compPredict}) * 2: {compPoints} points\n");
                    //Collect data for result table
                    compPredictions[i] = compPredict;
                    compDice[i] = compDiceSumm;
                    compResult[i] = compPoints;

                    //Current score output
                    if (userPoints > compPoints)
                    {
                        var result = userPoints - compPoints;
                        Console.WriteLine($"---------- Current score ---------\nUser:           {userPoints} points\nComputer:       {compPoints} points\nUser is ahead by {result} points!\n----------------------------------\n");
                    }
                    else if (userPoints < compPoints)
                    {
                        var result = compPoints - userPoints;
                        Console.WriteLine($"---------- Current score ---------\nUser:           {userPoints} points\nComputer:       {compPoints} points\nComputer is ahead by {result} points!\n----------------------------------\n");
                    }
                    else
                    {
                        Console.WriteLine($"---------- Current score ---------\nUser:           {userPoints} points\nComputer:       {compPoints} points\nIt's a draw in this round.\n----------------------------------\n");
                    }

                    int userTotal = userResult.Sum();
                    int compTotal = compResult.Sum();

                    if (i == 2)
                    {
                        Console.WriteLine("-------------- Finish game --------------");
                        Console.WriteLine("Round |           User |         Computer");
                        Console.WriteLine("------+----------------+-----------------");
                        Console.WriteLine($"      |Predicted:     {userPredictions[0]}|Predicted:      {compPredictions[0]}");
                        Console.WriteLine($" - 1 -|Dice:          {userDice[0]}|Dice:           {compDice[0]}");
                        Console.WriteLine($"      |Result:        {userResult[0]}|Result:         {compResult[0]}");
                        Console.WriteLine("------+----------------+-----------------");
                        Console.WriteLine($"      |Predicted:     {userPredictions[1]}|Predicted:      {compPredictions[1]}");
                        Console.WriteLine($" - 2 -|Dice:          {userDice[1]}|Dice:           {compDice[1]}");
                        Console.WriteLine($"      |Result:        {userResult[1]}|Result:         {compResult[1]}");
                        Console.WriteLine("------+----------------+-----------------");
                        Console.WriteLine($"      |Predicted:     {userPredictions[2]}|Predicted:      {compPredictions[2]}");
                        Console.WriteLine($" - 3 -|Dice:          {userDice[2]}|Dice:           {compDice[2]}");
                        Console.WriteLine($"      |Result:        {userResult[2]}|Result:         {compResult[2]}");
                        Console.WriteLine("------+----------------+-----------------");
                        Console.WriteLine($"Total |Points:        {userTotal}|Points:         {compTotal}");

                        if (userTotal > compTotal)
                        {
                            Console.WriteLine($"Users win {userTotal - compTotal} points more.\nCongratulations!");
                        }
                        else if (userTotal < compTotal)
                        {
                            Console.WriteLine($"Computer win {compTotal - userTotal} points more.");
                        }
                        else
                        {
                            Console.WriteLine("No winner. Pointa are equal.");
                        }

                        if (i == 2)
                        {
                            Console.WriteLine("Do you want to play ones more (Y/N)");
                            answer = Console.ReadLine();

                            if (answer == "N" || answer == "n")
                            {
                                play = false;
                            }
                            else if (answer == "Y" || answer == "y")
                            {
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Unknown command. Answer should be Y or N");
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void PrintDice(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("---------\n|       |\n|   #   |\n|       |\n---------");
                    break;
                case 2:
                    Console.WriteLine("---------\n|      #|\n|       |\n|#      |\n---------");
                    break;
                case 3:
                    Console.WriteLine("---------\n|      #|\n|   #   |\n|#      |\n---------");
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