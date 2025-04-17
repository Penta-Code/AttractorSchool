namespace HomeWork17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            string[] ChannelLimit = ["Movie", "Music", "Cartoon", "News", "Weather"];

            TV tv = new(ChannelLimit);
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown command");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Press + or - to switch channels or input channel number\nInput Q or q to shut down the TV");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Current channel: {tv[tv.CurrentChannel]}");
                }
            }
        }
    }
}