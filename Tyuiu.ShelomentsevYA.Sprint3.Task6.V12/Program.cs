using System;
using Tyuiu.ShelomentsevYA.Sprint3.Task6.V12.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Обработка целочисленной информации | Вариант 12";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Шеломенцев Я.А. | ИСТНб-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти среди целых чисел из диапазона [9, 18] сумму всех их делителей.   *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = 9;
            int stopValue = 18;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
