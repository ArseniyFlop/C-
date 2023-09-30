using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1. Класс Person");
            Console.WriteLine("2. Площадь и периметр фигуры");
            Console.WriteLine("3. Классы Author и Book");
            Console.WriteLine("4. Интерфейс IDrawable с методом Draw()");
            Console.WriteLine("5. Включение и выключение отопления исходя из температуры");
            Console.WriteLine("6. Банк аккаунт");
            Console.WriteLine("7. Домашняя библиотека");
            Console.WriteLine("8. Класс для определения одномерных массивов строк фиксированной длины");
            Console.WriteLine("0. Выйти из программы");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Вы выбрали задачу 1.");
                    // Создание объектов класса Person
                    Person person1 = new Person("Иван", 30, "Москва");
                    Person person2 = new Person("Мария", 25, "Санкт-Петербург");

                    // Вывод информации о созданных объектах
                    person1.PrintInfo();
                    Console.WriteLine();
                    person2.PrintInfo();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали задачу 2.");
                    // Создание объектов всех классов
                    Shape shape = new Shape();
                    Circle circle = new Circle(5.0);
                    Rectangle rectangle = new Rectangle(4.0, 6.0);

                    // Вывод информации о каждой фигуре

                    Console.WriteLine("Фигура: Круг (Circle)");
                    Console.WriteLine($"Площадь: {circle.Area()}");
                    Console.WriteLine($"Периметр: {circle.Perimeter()}");
                    Console.WriteLine();

                    Console.WriteLine("Фигура: Прямоугольник (Rectangle)");
                    Console.WriteLine($"Площадь: {rectangle.Area()}");
                    Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали задачу 3.");
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
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали задачу 4.");
                    // Создание массива объектов, реализующих интерфейс IDrawable
                    IDrawable[] shapes = new IDrawable[]
                    {
                        new Circle1(5),
                        new Rectangle1(4, 6),
                        new Triangle(3, 4, 5)
                    };

                    // Вызов метода Draw() для каждого объекта
                    Console.WriteLine("Рисование объектов:");
                    foreach (var shape1 in shapes)
                    {
                        shape1.Draw();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Вы выбрали задачу 5.");
                    // Создание объектов TemperatureSensor и Thermostat
                    TemperatureSensor sensor = new TemperatureSensor();
                    Thermostat thermostat = new Thermostat();

                    // Подписываем объект Thermostat на событие TemperatureChanged
                    sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

                    // Имитация изменения температуры
                    sensor.CurrentTemperature = 18.5;
                    sensor.CurrentTemperature = 22.0;
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    // Создание объекта BankAccount
                    BankAccount account = new BankAccount("1234567890", "Иван Иванов", 1000.0);

                    // Получение информации о счете
                    Console.WriteLine($"Номер счета: {account.GetAccountNumber()}");
                    Console.WriteLine($"Владелец счета: {account.GetOwner()}");
                    Console.WriteLine($"Баланс счета: {account.GetBalance()} рублей");

                    // Пополнение счета и снятие средств
                    account.Deposit(500.0);
                    account.Withdraw(300.0);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
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
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    // Создание объекта FixedLengthStringArray
                    FixedLengthStringArray array1 = new FixedLengthStringArray(3);
                    FixedLengthStringArray array2 = new FixedLengthStringArray(3);

                    // Заполнение массивов
                    array1[0] = "Привет, ";
                    array1[1] = "мир!";
                    array2[0] = "Программирование ";
                    array2[1] = "это интересно.";

                    // Вывод массивов
                    Console.WriteLine("Массив 1:");
                    array1.DisplayArray();

                    Console.WriteLine("\nМассив 2:");
                    array2.DisplayArray();

                    // Сцепление и вывод
                    array1.Concatenate(array2);
                    Console.WriteLine("\nМассив 1 после сцепления:");
                    array1.DisplayArray();

                    // Слияние и вывод
                    array1.Merge(array2);
                    Console.WriteLine("\nМассив 1 после слияния:");
                    array1.DisplayArray();

                    // Вывод элемента по индексу
                    array1.DisplayElement(2);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите задачу из списка.");
                    break;
            }
        }
    }
}