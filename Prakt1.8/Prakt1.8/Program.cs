using System;

public class FixedLengthStringArray
{
    private string[] dataArray;

    public FixedLengthStringArray(int length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Длина массива должна быть положительным числом.");
        }

        dataArray = new string[length];
    }

    public int Length
    {
        get { return dataArray.Length; }
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
            }

            return dataArray[index];
        }
        set
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
            }

            dataArray[index] = value;
        }
    }

    public void Concatenate(FixedLengthStringArray otherArray)
    {
        if (Length != otherArray.Length)
        {
            throw new ArgumentException("Длины массивов должны совпадать для сцепления.");
        }

        for (int i = 0; i < Length; i++)
        {
            dataArray[i] += otherArray[i];
        }
    }

    public void Merge(FixedLengthStringArray otherArray)
    {
        if (Length != otherArray.Length)
        {
            throw new ArgumentException("Длины массивов должны совпадать для слияния.");
        }

        for (int i = 0; i < Length; i++)
        {
            string currentString = dataArray[i];
            string otherString = otherArray[i];

            if (currentString == null)
            {
                dataArray[i] = otherString ?? "";
            }
            else if (otherString != null && !currentString.Contains(otherString))
            {
                dataArray[i] += otherString;
            }
        }
    }


    public void DisplayElement(int index)
    {
        Console.WriteLine($"Элемент массива с индексом {index}: {this[index]}");
    }

    public void DisplayArray()
    {
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < Length; i++)
        {
            Console.WriteLine($"[{i}]: {dataArray[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
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
    }
}
