using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class Card
    {
        private string _rank;
        private string _suit;

        public Card(string rank, string suit)
        {
            _rank = rank;
            _suit = suit;
        }

        public Card() { }

        public override string ToString() => $"{_rank}{_suit}";
    }
}