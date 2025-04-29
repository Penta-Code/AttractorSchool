namespace HomeWork20_2
{
    internal  class Employee
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Year { get; set; }

        public Employee(string number, string firstname, string lastname, string profession, string year)
        {
            Number = number;
            FirstName = firstname;
            LastName = lastname;
            Profession = profession;
            Year = year;
        }
    }
}