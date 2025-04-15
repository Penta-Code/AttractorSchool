using SecondMonthExam;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            string[] ChannelLimit = ["Movie", "Music", "Cartoon", "News", "Weather"];

            Television tv = new(3, ChannelLimit);
            tv.TurnOn();

            while (work)
            {
                var input = Console.ReadLine().Trim();

                if (input == "+")
                {
                    tv.nextChannel();
                }
                else if (input == "-")
                {
                    tv.previousChannel();
                }
                else if (int.TryParse(input, out int channel))
                {
                    tv.moveToChannel(channel);
                }
                else if (input == "Q" || input == "q")
                {
                    tv.TurnOff();
                    work = false;
                }
                else
                {
                    Console.WriteLine("Unknown channel");
                }
            }
        }
    }
}