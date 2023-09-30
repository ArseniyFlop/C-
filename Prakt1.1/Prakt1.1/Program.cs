using System;

public class Person
{
    // Поля для хранения имени, возраста и адреса
    private string name;
    private int age;
    private string address;

    // Конструктор класса для инициализации полей
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Методы для установки и получения значений полей
    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным.");
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    // Метод для вывода информации о человеке
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Адрес: {address}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов класса Person
        Person person1 = new Person("Иван", 30, "Москва");
        Person person2 = new Person("Мария", 25, "Санкт-Петербург");

        // Вывод информации о созданных объектах
        person1.PrintInfo();
        Console.WriteLine();
        person2.PrintInfo();
    }
}
