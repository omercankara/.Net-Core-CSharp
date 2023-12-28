using System;

class Program
{
    class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }

        public string Intro()
        {
            return $"isim: {Name} Yaş {CalculateAge()}" ;
        }
        public int CalculateAge()
        {
            return DateTime.Now.Year - Year;
        }

    }
    static void Main(string[] args)
    {
        Person p1 = new Person()
        {
            Name = "Eda",
            Year = 2001
        };

        Person p2 = new Person()
        {
            Name = "Seda",
            Year = 2002
        };

        Person p3 = new Person()
        {
            Name = "Ceyda",
            Year = 2003
        };

        var str1 = p1.Intro();
        Console.WriteLine(str1);

        var int1 = p1.CalculateAge();
        Console.WriteLine(int1);

    }
}