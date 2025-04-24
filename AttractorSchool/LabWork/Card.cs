namespace LabWork
{
    internal class Card
    {
        private string _rank;
        private string _suit;

        public string Rank { get => _rank; }
        public string Suit { get => _suit; }

        public Card(string rank, string suit)
        {
            _rank = rank;
            _suit = suit;
        }

        public override string ToString() => $"{_rank}{_suit}";
    }
}