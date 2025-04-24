namespace LabWork
{
    internal class Hand
    {
        public Card[] MyHand { get; private set; }
        public Hand()
        {
            MyHand = new Card[5];
        }

        public void FillHand(Card[] card)
        {
            MyHand = card;
        }

        public void ChangeCard(int index, Card card)
        {
            MyHand[index] = card;
        }

        public override string ToString()
        {
            return $"|  1   |  2   |  3   |  4   |  5   |\n|  {MyHand[0].ToString()}  |  {MyHand[1].ToString()}  |  {MyHand[2].ToString()}  |  {MyHand[3].ToString()}  |  {MyHand[4].ToString()}  |\n";
        }
    }
}