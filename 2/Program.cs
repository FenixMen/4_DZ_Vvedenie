using System;

namespace _2
{
    class Program
    {//Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую 
        //число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
        static bool CheckInt(ref string charToString, ref int sum)
        {
            if (int.TryParse(charToString, out int paarse))
            { 
                sum += paarse;
                charToString = "";
                return true;
            }
            else
            {
                return false;
            }         
        }


        static void Sum()
        {
            bool check = true;
            string charToString = "";
            int sum = 0;

            string userValue = Console.ReadLine();
            for (int i = 0; i < userValue.Length; i++)
            {
                if (userValue.Length - 1 == i && userValue[i] != ' ')
                {
                    charToString += userValue[i];
                    check = CheckInt(ref charToString, ref sum);
                }
                    if (userValue[i] != ' ')
                        charToString += userValue[i];
                    else
                    {
                       check = CheckInt(ref charToString, ref sum);
                        while (userValue[i] == ' ')
                        {
                            i++;
                            if (userValue.Length == i)
                            {
                                break;
                            }
                        }
                    i--;
                    }
            }
            if(check)
                Console.WriteLine($"Сумма чисел = {sum}");
            else
                Console.WriteLine("Данные ввдены не корректно!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел через пробел");
            Sum();
        }
    }
}
