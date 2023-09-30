using System;

// Класс, представляющий информацию о температуре
public class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Класс TemperatureSensor, генерирующий событие TemperatureChanged
public class TemperatureSensor
{
    private double currentTemperature;
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    public double CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            if (currentTemperature != value)
            {
                currentTemperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

// Класс Thermostat, управляющий отоплением
public class Thermostat
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        if (e.NewTemperature < 20.0)
        {
            Console.WriteLine("Температура ниже 20°C. Включаем отопление.");
        }
        else
        {
            Console.WriteLine("Температура выше 20°C. Выключаем отопление.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов TemperatureSensor и Thermostat
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat();

        // Подписываем объект Thermostat на событие TemperatureChanged
        sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

        // Имитация изменения температуры
        sensor.CurrentTemperature = 18.5;
        sensor.CurrentTemperature = 22.0;
    }
}
