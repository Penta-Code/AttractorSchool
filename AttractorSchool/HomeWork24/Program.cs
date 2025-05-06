namespace HomeWork24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readPath = AskFilePath.ReadPath();
            string writePath = AskFilePath.WritePath();

            AppMenu.Start();
        }
    }
}