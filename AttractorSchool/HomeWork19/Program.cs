namespace HomeWork19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Store store = new();
            store.DoInspection();
        }
    }
}
