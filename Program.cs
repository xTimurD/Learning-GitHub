using System;
using bal;
using MileToKmConverter;
using ruzil;
using hafizov;
using valiev;
class GigantProgram{
    static void Main(string[] args){



    Console.WriteLine("------------------------------------");
    Console.WriteLine("Введите номер нужной программы (1-5)");
    Console.WriteLine("1. Программа Балышевой");
    Console.WriteLine("2. Программа Имаева");
    Console.WriteLine("3. Программа Сайгатдинова");
    Console.WriteLine("4. Программа Хафизова");
    Console.WriteLine("5. Программа Валиева");
    Console.WriteLine("------------------------------------");

        string str = Console.ReadLine();
        
        if (str.Equals("1"))

        {
            Nastia.solution();
        }

        
        else if (str.Equals("2"))
        {
            MileToKm.show();
            return;


        }
        else if (str.Equals("3"))
        {
            Program2.solution();
        }


        else if (str.Equals("4"))
        {
            Program3.solution();
            return;
        }
        else if (str.Equals("5"))
        {
            GlassCalculator.SDs();
            return;
        }
        else{
            Console.WriteLine("Попробуйте еще раз");
            return;
        }

    }
}













