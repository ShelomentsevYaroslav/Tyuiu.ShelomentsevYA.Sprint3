using System;
using Tyuiu.ShelomentsevYA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить по формуле:                                                   *");
            Console.WriteLine("* y = ΣΣ(sin(x) + 2/k), при x = 5, i = 1..3, k = 1..14                    *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 5;
            double y = ds.GetSumSumSeries(x, 1, 1, 3, 14);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
