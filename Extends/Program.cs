using System;


class Program
{

    class Person
    {
        public string Name { get; set; } = string.Empty;
        public string surName { get; set; } = string.Empty;
        public int Age { get; set; }
        public Person(string Name, string surName)
        {
            this.Name = Name;
            this.surName = surName;
        }
        public virtual void intro()
        {
            Console.WriteLine($"My Name is : {this.Name} Surname: {this.surName} ı am developer");
        }
    }

    class Student : Person
    {
        public int studentNumber { get; set; }
        public Student(string Name, string surName, int studentNumber) : base(Name, surName)
        {
            this.studentNumber = studentNumber;
        }
        public override void intro()
        {
            Console.WriteLine($"Name {this.Name} Number: {this.studentNumber}");
        }

    }

    class Teacher : Person
    {
        public string Branch { get; set; }

        public Teacher(string Name, string surName, string branch) : base(Name, surName)
        {
            this.Branch = branch;
        }
        public void Teach()
        {
            Console.WriteLine($"My Name is {this.Name} I Am Teachigng {this.Branch}");
        }

        public override void intro()
        {
            Console.WriteLine($"Overide işlemi Name {this.Name} Number: {this.Branch}");
        }
    }



    static void Main(string[] args)
    {
        var Person = new Person("Ömercan", "Kara");
        var Student = new Student("Eda", "Kara", 50);
        var Teacher = new Teacher("Melike", "Kara", "Sosyal Bilgiler");
        Person.intro();
        Student.intro();
        Teacher.Teach();
        Teacher.intro();
    }


}