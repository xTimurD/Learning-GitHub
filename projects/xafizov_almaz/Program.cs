using System;

namespace hafizov {
class Program3
{
    enum PaperSize // перечисление форматов бумаги
    {
        A5,
        A4,
        A3,
        A2,
        A1,
        A0
    }

    public static void solution()
    {
        int copies; // количество копий
        PaperSize size; // формат бумаги
        double price; // цена за копию
        double total; // общая стоимость заказа
        bool withCustomer; // условие выполнения заказа

        Console.WriteLine("Введите количество копий:");
        copies = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите формат бумаги:");
        Console.WriteLine("0 - A5");
        Console.WriteLine("1 - A4");
        Console.WriteLine("2 - A3");
        Console.WriteLine("3 - A2");
        Console.WriteLine("4 - A1");
        Console.WriteLine("5 - A0");
        size = (PaperSize)int.Parse(Console.ReadLine());

        Console.WriteLine("Условия выполнения заказа:");
        Console.WriteLine("0 - В присутствии заказчика");
        Console.WriteLine("1 - На следующий день");
        withCustomer = int.Parse(Console.ReadLine()) == 0;

        switch (size)
        {
            case PaperSize.A5:
                price = 2.5;
                break;
            case PaperSize.A4:
                price = 3.0;
                break;
            case PaperSize.A3:
                price = 4.5;
                break;
            case PaperSize.A2:
                price = 9.0;
                break;
            case PaperSize.A1:
                price = 18.0;
                break;
            case PaperSize.A0:
                price = 28.0;
                break;
            default:
                Console.WriteLine("Ошибка: выберите формат бумаги из списка.");
                return;
        }

        total = price * copies;

        if (withCustomer)
        {
            total *= 1.5;
        }

        Console.WriteLine("Стоимость заказа составляет: " + total + " рублей.");
    }
}
}