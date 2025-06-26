using System;

public class Singleton
{
    // Статическое поле для хранения единственного экземпляра
    private static Singleton _instance;

    // Приватный конструктор (запрет создания через new)
    private Singleton() { }

    // Публичное свойство для доступа к экземпляру
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    // Какой-то метод класса для проверки жизнеспособности программы
    public void AGA()
    {
        Console.WriteLine("googoogaga");
    }
}

class Program
{
    static void Main()
    {
        Singleton singleton = Singleton.Instance;
        singleton.AGA();
    }
}