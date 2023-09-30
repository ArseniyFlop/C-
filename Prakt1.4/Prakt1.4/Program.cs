using System;

// Интерфейс IDrawable
public interface IDrawable
{
    void Draw();
}

// Класс Circle, реализующий интерфейс IDrawable
public class Circle1 : IDrawable
{
    private double radius;

    public Circle1(double radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем круг с радиусом {radius}");
    }
}

// Класс Rectangle, реализующий интерфейс IDrawable
public class Rectangle1 : IDrawable
{
    private double width;
    private double height;

    public Rectangle1(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем прямоугольник шириной {width} и высотой {height}");
    }
}

// Класс Triangle, реализующий интерфейс IDrawable
public class Triangle : IDrawable
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2} и {side3}");
    }
}

class Program
{
    static void Main(string[] args)
    {
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
    }
}
