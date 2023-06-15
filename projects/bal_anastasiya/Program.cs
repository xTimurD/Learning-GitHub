using System;

class Program4
{
    static void Main(string[] args)
    {
        double celsius; // градусы Цельсия
        double fahrenheit; // градусы Фаренгейта
        double kelvin; // Кельвины

        Console.WriteLine("Введите температуру в градусах Цельсия:");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = celsius * 9.0 / 5.0 + 32.0;
        kelvin = celsius + 273.15;

        Console.WriteLine("Температура в градусах Фаренгейта: " + fahrenheit);
        Console.WriteLine("Температура в Кельвинах: " + kelvin);
    }
}