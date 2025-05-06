using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork24
{
    internal static class AskFilePath
    {
        public static string ReadPath()
        {
            Console.WriteLine("Введите путь и имя файла для считывания данных:");
            string ReadFilePath = Console.ReadLine();

            while (!File.Exists(ReadFilePath))
            {
                Console.WriteLine("Файл не найден. Проверьте путь и имя файла для считывания данных.");
                ReadFilePath = Console.ReadLine();
            }

            return ReadFilePath;
        }

        public static string WritePath()
        {
            Console.WriteLine("Введите путь и имя файла для записи данных:");
            string WriteFilePath = Console.ReadLine();

            while (!File.Exists(WriteFilePath))
            {
                Console.WriteLine("Файл не найден. Проверьте путь и имя файла для записи данных.");
                WriteFilePath = Console.ReadLine();
            }

            return WriteFilePath;
        }
    }
}