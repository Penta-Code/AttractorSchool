namespace HomeWork24
{
    public class Driver
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public Driver(string name, string surname, int age, int experience)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}