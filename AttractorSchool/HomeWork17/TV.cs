//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

namespace HomeWork17
{
    internal class TV
    {
        public int CurrentChannel { get; set; }
        public string[] ChannelLimit { get; } = ["Channel 0", "Channel 1", "Channel 2", "Channel 3", "Channel 4"];
        
        public TV(int currentChannel, string[] channelLimit)
        {
            CurrentChannel = currentChannel;
            ChannelLimit = channelLimit;
        }

        public TV(string[] channelLimit) : this(0, channelLimit)
        { }

        public TV()
        { }

        public void nextChannel()
        {
            if (CurrentChannel >= ChannelLimit.Length - 1)
            {
                CurrentChannel = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
            else
            {
                CurrentChannel++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
        }

        public void previousChannel()
        {
            if (CurrentChannel <= 0)
            {
                CurrentChannel = ChannelLimit.Length - 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
            else
            {
                CurrentChannel--;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
        }

        public void moveToChannel(int channel)
        {
            CurrentChannel = channel;

            if (CurrentChannel < 0 || CurrentChannel > ChannelLimit.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Channel number must be between 0 and {ChannelLimit.Length - 1}");
                CurrentChannel = 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
        }

        public void TurnOn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"TV is turned on");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"Loading...");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Press + or - to switch channels or input channel number");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TurnOff()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nShutting down...");
            System.Threading.Thread.Sleep(1500);
        }
    }
}