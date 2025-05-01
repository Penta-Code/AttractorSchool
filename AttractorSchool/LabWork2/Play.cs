using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class Play
    {
        private static string? Word { get; set; }


        public Play()
        {
            Word = WordSelector.SelectWord(); //"textnote";
        }

        private string MakeWordHidden(string word)
        {
            return new string('*', word.Length);
        }

        public void GuessLetter()
        {
            char[] selectedWord = MakeWordHidden(Word).ToCharArray();
            int attempts = Word.Length * 2;
            int attemptsCounter = 1;
            bool IsEquals = false;
            char inputChar = ' ';

            Console.WriteLine($"Загадано слово из {Word.Length} букв: {new string(selectedWord)}\nКоличество попыток: {attempts}");

            while (attemptsCounter <= attempts)
            {
                string input = InputProcessing.Processing();

                if (input.Length > 1)
                {
                    if (input == Word)
                    {
                        Console.WriteLine($"\nВы победили! Загаданное слово \"{Word}\". Вы победели с {attemptsCounter} попыток");
                        IsEquals = true;
                        break;
                    }
                }
                else
                {
                    inputChar = Convert.ToChar(input.ToLower());
                }

                for (int i = 0; i < Word.Length; i++)
                {
                    if (inputChar == Word[i])
                    {
                        selectedWord[i] = inputChar;
                        IsEquals = true;
                    }
                }

                if (new string(selectedWord) == Word)
                {
                    Console.WriteLine($"\nВы победили! Загаданное слово \"{Word}\". Вы победели с {attemptsCounter} попыток");
                    break;
                }
                else if (IsEquals)
                {
                    Console.WriteLine($"\n{new string(selectedWord)}\nВы угадали! Осталось попыток: {attempts - attemptsCounter}");
                    attemptsCounter++;
                }
                else
                {
                    Console.WriteLine($"\n{new string(selectedWord)}\nНет такой буквы! Осталось попыток: {attempts - attemptsCounter}");
                    attemptsCounter++;
                }

                IsEquals = false;
            }

            if(!IsEquals)
            Console.WriteLine($"\nИгра окончена! Все попытки исчерпаны. Слово не отгадано:\n{new string(selectedWord)}");
        }
    }
}