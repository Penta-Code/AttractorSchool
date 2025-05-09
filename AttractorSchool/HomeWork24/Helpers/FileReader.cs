namespace HomeWork24.Helpers
{
    internal static class FileReader
    {
        public static string ReadData(string path)
        {
            string trucks = File.ReadAllText(path);
            return trucks;
        }

        public static void WriteData(string path, string data)
        {
            File.AppendAllText(path, DateTime.Now.ToString());
            File.AppendAllText(path, data);
        }
    }
}