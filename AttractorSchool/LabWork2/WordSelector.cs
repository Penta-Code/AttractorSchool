using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal static class WordSelector
    {
        public static string SelectWord()
        {
            string[] words = FileReader.GetWords();

            if (words.Length == 0 || words[0] == " ")
            {
                throw new FileNotFoundException();
            }

            int rnd = new Random().Next(0, words.Length);
            return words[rnd];
        }
    }
}