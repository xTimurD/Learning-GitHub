using System;

namespace ruzil {
class Program2
{
    public static void solution()
    {
        int size; // размер фото: 1 - 9x12, 2 - 12x15, 3 - 18x24
        int quantity; // количество фото
        double price; // цена за фото
        double total; // общая стоимость заказа
        
        Console.WriteLine("Введите размер фото: 1 - 9x12, 2 - 12x15, 3 - 18x24");
        size = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество фото:");
        quantity = int.Parse(Console.ReadLine());

        switch (size)
        {
            case 1:
                price = 1.5;
                break;
            case 2:
                price = 2.0;
                break;
            case 3:
                price = 3.0;
                break;
            default:
                Console.WriteLine("Ошибка: выберите размер фотографии из списка.");
                return;
        }

        total = price * quantity;

        if (quantity > 20)
        {
            total *= 0.9;
        }

        Console.WriteLine("Стоимость заказа составляет: " + total + " рублей.");
    }
}
}