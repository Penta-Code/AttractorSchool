namespace HomeWork20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Divider.AskX();
            string y = Divider.AskY();

            Divider.Divide(x, y);
        }
    }
}