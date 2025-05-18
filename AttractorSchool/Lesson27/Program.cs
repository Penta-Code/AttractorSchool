using System.Text.RegularExpressions;

namespace Lesson27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                            I do not like the, Sam-I-am.
                            I do not like green eggs and ham.";

            Dictionary<string, int> frequencies = CountWords(text);

            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                // Вывод пар "ключ-значение" на основе карты
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine($"{word}: {frequency}");
            }

            // Функция создает Dictionary<string, int> по входящей строке
            Dictionary<string, int> CountWords(string text)
            {

                // (1) Создание новой карты слов и частот
                Dictionary<string, int> frequencies = new Dictionary<string, int>();

                // (2) Разбиение текста на слова
                string[] words = Regex.Split(text, @"\W+");

                foreach (string word in words)
                {
                    // (3) Добавление или обновление карты
                    if (frequencies.ContainsKey(word))
                    {
                        frequencies[word]++;
                    }
                    else
                    {
                        frequencies[word] = 1;
                    }
                }

                return frequencies;
            }
        }
    }
}
