using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startI, int startK, int stopI, int stopK)
        {
            double y = 0;

            for (int i = startI; i <= stopI; i++)
                for (int k = startK; k <= stopK; k++)
                    y += Math.Sin(x) + 2.0 / k;

            return Math.Round(y, 3);
        }

    }
}
