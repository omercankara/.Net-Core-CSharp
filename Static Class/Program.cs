using System;


class Program
{
    class Student
    {
        public string name { get; set; }
        public int number { get; set; }
        public static string school { get; set; } = "Teknik Lise";
        public static string adress { get; set; } = "İstanbul/Besiktas";

        public Student(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public void displayStudentDetails()
        {
            Console.WriteLine($"name: {this.name} {this.number}");
        }

        public void displaySchoolDetails()
        {
            Console.WriteLine($"School: {school}");
        }
    }

    static class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return str.Replace("ö", "o");
        }
    }

    static void Main(string[] args)
    {
        string str = "ölçme";
        var results = HelperMethods.KarakterDuzelt(str);
        Console.WriteLine(results);
    }
}