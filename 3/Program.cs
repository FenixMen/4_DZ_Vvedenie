using System;

namespace _3
{
    class Program
    {//Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
        //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, 
        //принимающий на вход значение из этого перечисления и возвращающий название времени года 
        //(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести 
        //название времени года. Если введено некорректное число, вывести в консоль текст 
        //«Ошибка: введите число от 1 до 12».
     
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error = 20
        }
        static void SeasonOut(int mounth)
        {
            if (mounth == 12 || mounth == 1 || mounth == 2)
                SeasonCheck(0);
            if (mounth > 2 && mounth < 6)
                SeasonCheck(1);
            if (mounth > 5 && mounth < 9)
                SeasonCheck(2);
            if (mounth > 8 && mounth < 12)
                SeasonCheck(3);
            if (mounth < 1 || mounth > 12)
                SeasonCheck(20);
        }
        static void SeasonCheck(int mounth)
        {
            if (mounth == (int)Season.Autumn)
               Console.WriteLine("Осень");
            if (mounth == (int)Season.Summer)
                Console.WriteLine("Лето");
            if (mounth == (int)Season.Spring)
                Console.WriteLine("Весна");
            if (mounth == (int)Season.Winter)
                Console.WriteLine("Зима");
            if (mounth == (int)Season.Error)
                Console.WriteLine("Ошибка: введите число от 1 до 12");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");

            int mounth = int.TryParse(Console.ReadLine(), out mounth) ? mounth : mounth = 20;
            SeasonOut(mounth);
        }
    }
}
