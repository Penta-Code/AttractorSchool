using LabWork3.LaptopState;

namespace LabWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Laptop acer = new(false, new LaptopOnState());
                //acer.TurnOn();
                acer.StartProgramm();
                Console.WriteLine(acer.RunningProgramm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
