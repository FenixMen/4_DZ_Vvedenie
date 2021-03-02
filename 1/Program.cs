using System;

namespace _1
{
    class Program
    {//Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО 
        //в разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        static void Main(string[] args)
        {          
            Console.WriteLine(GetFullName("Гена", "Булгаков", "Чебурашкович"));
            Console.WriteLine(GetFullName("Виталий", "Назаров", "Васильевич"));
            Console.WriteLine(GetFullName("Рон", "Пон", "Кон"));
        }
    }
}
