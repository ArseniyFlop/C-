using System;
using System.Collections.Generic;
using System.Linq;

// Класс, представляющий книгу
public class Book1
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} (Автор: {Author}, Год издания: {Year})";
    }
}

// Класс "Домашняя библиотека"
public class HomeLibrary
{
    private List<Book1> books;

    public HomeLibrary()
    {
        books = new List<Book1>();
    }

    // Метод для добавления книги
    public void AddBook(string title, string author, int year)
    {
        books.Add(new Book1 { Title = title, Author = author, Year = year });
    }

    // Метод для удаления книги по названию
    public void RemoveBook(string title)
    {
        books.RemoveAll(book => book.Title == title);
    }

    // Метод для поиска книги по автору
    public List<Book1> FindBooksByAuthor(string author)
    {
        return books.Where(book => book.Author == author).ToList();
    }

    // Метод для поиска книги по году издания
    public List<Book1> FindBooksByYear(int year)
    {
        return books.Where(book => book.Year == year).ToList();
    }

    // Метод для сортировки книг по названию
    public void SortBooksByTitle()
    {
        books.Sort((book1, book2) => book1.Title.CompareTo(book2.Title));
    }

    // Метод для сортировки книг по автору
    public void SortBooksByAuthor()
    {
        books.Sort((book1, book2) => book1.Author.CompareTo(book2.Author));
    }

    // Метод для сортировки книг по году издания
    public void SortBooksByYear()
    {
        books.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
    }

    // Метод для вывода списка книг в библиотеке
    public void DisplayLibrary()
    {
        Console.WriteLine("Список книг в библиотеке:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HomeLibrary library = new HomeLibrary();

        // Добавление книг в библиотеку
        library.AddBook("Война и мир", "Лев Толстой", 1869);
        library.AddBook("Преступление и наказание", "Фёдор Достоевский", 1866);
        library.AddBook("1984", "Джордж Оруэлл", 1949);

        // Вывод списка книг
        library.DisplayLibrary();

        // Поиск книги по автору
        List<Book1> dostoevskyBooks = library.FindBooksByAuthor("Фёдор Достоевский");
        Console.WriteLine("\nКниги Фёдора Достоевского:");
        foreach (var book in dostoevskyBooks)
        {
            Console.WriteLine(book);
        }

        // Удаление книги
        library.RemoveBook("1984");
        Console.WriteLine("\nПосле удаления книги '1984':");
        library.DisplayLibrary();

        // Сортировка книг по автору и вывод отсортированного списка
        library.SortBooksByAuthor();
        Console.WriteLine("\nСписок книг после сортировки по автору:");
        library.DisplayLibrary();
    }
}
