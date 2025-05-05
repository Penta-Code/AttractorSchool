namespace HomeWork22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new();
            Laptop laptop = new();
            Phone phone = new();

            fridge.TurnOn();
            fridge.Frost();
            fridge.Defrost();
            fridge.TurnOff();

            laptop.TurnOn();
            laptop.RunProgramm();
            laptop.StopProgramm();
            laptop.TurnOff();

            phone.TurnOn();
            phone.BluetoothOn();
            phone.BluetoothOff();
            phone.TurnOff();
        }
    }
}