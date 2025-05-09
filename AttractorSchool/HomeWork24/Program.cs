using HomeWork24.Helpers;

namespace HomeWork24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readPath = AskFilePath.ReadPath();
            string writePath = AskFilePath.WritePath();
            Truck[] trucks = GetTrucks.TrucksList(readPath);
            Console.Clear();

            try
            {
                while (true)
                {
                    AppMenu.Start(readPath, writePath, trucks);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}