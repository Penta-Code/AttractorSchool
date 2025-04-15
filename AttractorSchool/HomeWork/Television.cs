using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SecondMonthExam
{
    public class Television
    {
        public int CurrentChannel { get; set; }
        public string[] ChannelLimit { get; } = [];

        public Television(int currentChannel, string[] channelLimit)
        {
            CurrentChannel = currentChannel;
            ChannelLimit = channelLimit;
        }

        public Television(string[] channelLimit) : this(0, channelLimit)
        { }

        public void nextChannel()
        {
            if (CurrentChannel >= ChannelLimit.Length -1)
            {
                CurrentChannel = 0;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
            else
            {
                CurrentChannel++;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
        }

        public void previousChannel()
        {
            if (CurrentChannel <= 0)
            {
                CurrentChannel = ChannelLimit.Length -1;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
            else
            {
                CurrentChannel--;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
        }

        public void moveToChannel(int channel)
        {
            if (channel >= 0 && channel <= ChannelLimit.Length)
            {
                CurrentChannel = channel;
                Console.WriteLine($"Current channel: {CurrentChannel} - {ChannelLimit[CurrentChannel]}");
            }
            else
            {
                Console.WriteLine("Unknown channel");
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
            Console.WriteLine($"Current channel: { CurrentChannel} - { ChannelLimit[CurrentChannel]}\nPress + or - to switch channels one by one. Input number to switch channel directly");
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