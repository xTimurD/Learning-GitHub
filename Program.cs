using System;
using bal;
using MileToKmConverter;
using ruzil;
using hafizov;
using valiev;
class GigantProgram{
    static void Main(string[] args){


    string str = " ";
        while(!str.Equals("0")) {

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Введите номер нужной программы (1-5)");
                Console.WriteLine("1. Программа Балышевой");
                Console.WriteLine("2. Программа Имаева");
                Console.WriteLine("3. Программа Сайгатдинова");
                Console.WriteLine("4. Программа Хафизова");
                Console.WriteLine("5. Программа Валиева");
                Console.WriteLine("6. Информация о программе");
                Console.WriteLine("0. Выход");
                Console.WriteLine("------------------------------------");

       str = Console.ReadLine();
        
        if (str.Equals("1"))

        {
            Nastia.solution();
        }

        
        else if (str.Equals("2"))
        {
            MileToKm.show();


        }
        else if (str.Equals("3"))
        {
            Program2.solution();
        }


        else if (str.Equals("4"))
        {
            Program3.solution();
        }
        else if (str.Equals("5"))
        {
            GlassCalculator.SDs();
        }
        else if (str.Equals("6"))
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Информация о программе:");
            Console.WriteLine(" ");
            Console.WriteLine("Организатор:");
            Console.WriteLine("Давлетгареев Тимур");
            Console.WriteLine("Тестировщики:");
            Console.WriteLine("1. Давлетгареев Тимур");
            Console.WriteLine("2. Имаев Алмаз");
            Console.WriteLine("3. Балышева Анастасия");
            Console.WriteLine(" ");
            Console.WriteLine("Программисты:");
            Console.WriteLine("1. Имаев Алмаз");
            Console.WriteLine("2. Балышева Анастасия");
            Console.WriteLine("3. Валиев Азат (Давлетгареев Тимур)");
            Console.WriteLine("4. Хафизов Алмаз (Давлетгареев Тимур)");
            Console.WriteLine("5. Сайгатдинов Рузиль (Давлетгареев Тимур)");
            Console.WriteLine(" ");
            Console.WriteLine("Собрал программу: Давлетгареев Тимур");
            Console.WriteLine("Программа завершена: 15.06.23");
            Console.WriteLine("Версия программы: 1.0");
            Console.WriteLine("------------------------------------");

            return;
        }
        else if (str.Equals("0")){
        }
        else{
            Console.WriteLine("Попробуйте еще раз");
        }
        }
     }
}













