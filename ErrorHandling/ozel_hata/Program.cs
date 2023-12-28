using System;

//Exception

//custom exception
//IndexOutOfRangeException => DİZİ SINIRI AŞMA  DURUMU
//login => username, password

class LoginException : Exception
{
    public LoginException(string message) : base(message)
    {

    }
}
class Program
{
    static void Login(string username, string Password)
    {
        if (username.Contains(" "))
        {
            throw new LoginException("Username boşluk içeremez");
        }
        if (Password.Length < 8)
        {
            throw new LoginException("Parola Minimum 8 karakter olmalı");
        }
        Console.WriteLine("İşlem Başarılı");
    }
    static void Main(string[] args)
    {
        try
        {
            Login("ÖmercanKara","123455678cls");
        }
        catch (LoginException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}