using System;
using System.Collections.Generic;

// Класс Author
public class Author
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Author(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public override string ToString()
    {
        return $"{Name} ({YearOfBirth} год рождения)";
    }
}

// Класс Book
public class Book
{
    public string Title { get; }
    public int YearOfPublication { get; }
    public Author Author { get; }

    public Book(string title, int yearOfPublication, Author author)
    {
        Title = title;
        YearOfPublication = yearOfPublication;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} ({YearOfPublication}), автор: {Author}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов Author
        Author author1 = new Author("Лев Толстой", 1828);
        Author author2 = new Author("Фёдор Достоевский", 1821);

        // Создание объектов Book с использованием созданных авторов
        Book book1 = new Book("Война и мир", 1869, author1);
        Book book2 = new Book("Преступление и наказание", 1866, author2);
        Book book3 = new Book("Анна Каренина", 1877, author1);

        // Вывод информации о книгах и их авторах
        Console.WriteLine("Информация о книгах и авторах:");
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}
