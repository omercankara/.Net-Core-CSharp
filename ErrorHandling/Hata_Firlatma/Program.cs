using System;
using System.Linq;

class Program
{
    class Person
    {
        string? _name;
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value?.Length > 5)
                {
                    throw new Exception("Name değeri en fazla 5 karakter olabilir");
                }
                _name = value;
            }

        }
    }

    static void Check_password(string password)
    {
        if (password.Length < 8 || password.Length > 15)
        {
            throw new Exception("Parola 7 ile 15 karakter arasında olmalıdır");
        }
        if (!password.Any(char.IsDigit))
        {
            throw new Exception("Parola en az 1 rakarm içermelidir.");
        }
        if (!password.Any(char.IsLetter))
        {
            throw new Exception("Parola en az 1  harf içermelidir.");
        }
    }
    static void Main(string[] args)
    {
        //Exception handlign
        // string parola = "12345678a";
        // try
        // {
        //     Check_password(parola);
        //     Console.WriteLine("Parola Geçerlidir.");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        try
        {
            var p = new Person();
            p.Name = "omercan";

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}