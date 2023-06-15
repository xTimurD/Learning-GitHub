using System;

public class GlassCalculator
{
    public void SDs()
    {
       Console.Write("Введите ширину (мм): ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Введите высоту (мм): ");
        double height = double.Parse(Console.ReadLine());

        // Ввод типа механизма открывания
        Console.Write("Выберите тип механизма открывания (1 - поворотный, 2 - поворотно-откидной): ");
        int mechanismType = int.Parse(Console.ReadLine());

        // Ввод дополнительных опций
        Console.WriteLine("Выберите дополнительные опции:");
        Console.WriteLine("1 - фиксатор");
        Console.WriteLine("2 - микропроветривание");
        Console.WriteLine("3 - москитная сетка");

        Console.Write("Введите номера опций, через запятую: ");
        string[] optionsInput = Console.ReadLine().Split(',');

        bool hasFixator = Array.Exists(optionsInput, el => el.Trim() == "1");
        bool hasMicroVent = Array.Exists(optionsInput, el => el.Trim() == "2");
        bool hasMosquitoNet = Array.Exists(optionsInput, el => el.Trim() == "3");

        // Расчет стоимости
        double area = (width / 1000) * (height / 1000);
        double price = 1000 * area; // базовая стоимость

        if (mechanismType == 2)
        {
            price += 5000; // поворотно-откидной механизм
        }

        if (hasFixator)
        {
            price += 1000;
        }

        if (hasMicroVent)
        {
            price += 1500;
        }

        if (hasMosquitoNet)
        {
            price += 2000;
        }

        // Вывод результатов
        Console.WriteLine($"Стоимость стеклопакета: {price} руб.");
    }
}
