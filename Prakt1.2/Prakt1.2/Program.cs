using System;

// Базовый класс Shape
public class Shape
{
    // Метод для вычисления площади
    public virtual double Area()
    {
        return 0;
    }

    // Метод для вычисления периметра
    public virtual double Perimeter()
    {
        return 0;
    }
}

// Производный класс Circle
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Производный класс Rectangle
public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
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
    }
}
