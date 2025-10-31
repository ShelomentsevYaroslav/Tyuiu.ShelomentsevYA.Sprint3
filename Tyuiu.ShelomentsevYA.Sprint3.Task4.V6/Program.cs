using System;
using Tyuiu.ShelomentsevYA.Sprint3.Task4.V6.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = x / (cos(x) - sin(x))                                       *");
            Console.WriteLine("* При x = 0 прервать цикл. Полученные значения суммировать.              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
          
            Console.ReadKey();
        }
    }
}
