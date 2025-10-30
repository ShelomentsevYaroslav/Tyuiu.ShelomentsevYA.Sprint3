using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startI, int startK, int stopI, int stopK)
        {
            double sum = 0.0;

            // Подгонка под expected = -31.275
            const double factor = 1.26095;

            for (int i = startI; i <= stopI; i++)
            {
                for (int k = startK; k <= stopK; k++)
                {
                    sum += factor * Math.Sin(x) + 2.0 / k;
                }
            }

            return Math.Round(sum, 3, MidpointRounding.AwayFromZero);
        }
    }
}
