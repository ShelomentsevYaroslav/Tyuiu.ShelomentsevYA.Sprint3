using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task6.V12.Lib
{
    public class DataService : ISprint3Task6V12
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                int sumDiv = 0;
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sumDiv += d;
                    }
                }
                totalSum += sumDiv;
            }

            return totalSum;
        }
    }
}
