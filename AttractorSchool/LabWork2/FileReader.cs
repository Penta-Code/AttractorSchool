using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class FileReader
    {
        private const string path = "../../../words.txt";
        public static string[] GetWords()
        {
            return File.ReadAllLines(path);
        }
    }
}