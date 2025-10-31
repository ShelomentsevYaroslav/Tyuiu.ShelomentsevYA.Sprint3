using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Cos(x) + 1;      
                double fx;

                if (denom == 0)
                    fx = 0;                          
                else
                    fx = 3 * x + 2 - (x / denom);

                result[i++] = Math.Round(fx, 2);     
            }

            return result;
        }
    }
}
