namespace HomeWork24.Helpers
{
    internal static class CreateDriver
    {
        private static string[] _names = { "Steve", "James", "Bill", "Tony", "Tim"};
        private static string[] _surnames = { "Jobs", "Armstrong", "Gates", "Hawk", "Cook" };

        public static Driver GetDriver()
        {
            string name = _names[new Random().Next(0, 5)];
            string surname = _surnames[new Random().Next(0, 5)];
            int age = new Random().Next(30, 60);
            int experience = new Random().Next(5, 15);

            Driver driver = new Driver(name, surname, age, experience);
            return driver;
        }
    }
}