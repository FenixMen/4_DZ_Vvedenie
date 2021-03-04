using System;

namespace _4
{
    class Program
    {//Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
        static int fib1 = 0; //начальное число 0 или 1 в последовательности
        static int fib2 = 1;

        static int Fibonachi(int userValue, ref int fib1)
        {
            if(userValue < 3)
                Console.WriteLine("Введите значение побольше");
            return 0;
            if (userValue - 3 == 0)
            {
                Console.Write($"{fib1} {fib2} {fib1 + fib2} ");
                return fib1 + fib2;
            }
            else
            {
                int result = Fibonachi(userValue - 1, ref fib1);
                Console.Write($"{result + fib2} ");
                fib1 = fib2;
                fib2 = result;
                return fib1 + result;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну последовательности");
            int userValue = int.TryParse(Console.ReadLine(), out userValue) ? userValue : 0;
            Fibonachi(userValue, ref fib1);
        }
    }
}