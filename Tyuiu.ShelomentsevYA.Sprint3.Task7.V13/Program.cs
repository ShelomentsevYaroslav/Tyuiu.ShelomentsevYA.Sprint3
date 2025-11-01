using System;
using Tyuiu.ShelomentsevYA.Sprint3.Task7.V13.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вывести таблицу значений функции F(x) = 3x + 2 - (2x - x)/(cos(x^3)+1). *");
            Console.WriteLine("* Диапазон: [-5; 5], шаг = 1. Проверить деление на ноль.                  *");
            Console.WriteLine("* При делении на ноль вернуть 0.                                          *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ: Таблица значений функции                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*F(x)                                                                     *");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($"*   {x,3}   |   {result[index],8:F2}                                       *");
                index++;
            }
            Console.ReadKey();
        }
    }
}
