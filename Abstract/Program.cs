using System;

class Program
{
    abstract class Person
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int Age { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Greeting()
        {
            Console.WriteLine("I Am a person");
        }


        public abstract void Intro();
    }

    class Student : Person
    {
        public int StudentNumber { get; set; }

        public Student(string name, string surname, int studentNumber) : base(name, surname)
        {
            StudentNumber = studentNumber;
        }

        public override void Intro()
        {
            Console.WriteLine($"Name: {Name}, Student Number: {StudentNumber}");
        }
    }

    class Teacher : Person
    {
        public string Branch { get; set; }

        public Teacher(string name, string surname, string branch) : base(name, surname)
        {
            Branch = branch;
        }

        public void Teach()
        {
            Console.WriteLine($"My Name is {Name}. I am teaching {Branch}");
        }

        public override void Intro()
        {
            Console.WriteLine($"Override operation. Name: {Name}, Branch: {Branch}");
        }
    }

    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a square");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
    static void Main(string[] args)
    {
        var Shape = new Shape[3];
        Shape[0] = new Shape();
        Shape[1] = new Square();
        Shape[2] = new Rectangle();

        foreach (var shap in Shape)
        {
            shap.Draw();
        }

    }
}
