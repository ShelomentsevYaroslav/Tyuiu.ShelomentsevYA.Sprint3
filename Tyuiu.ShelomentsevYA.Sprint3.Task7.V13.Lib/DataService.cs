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

            
            int index = 0;

            
            for (int x = startValue; x <= stopValue; x++)
            {
                
                double denominator = Math.Cos(Math.Pow(x, 3)) + 1;

                if (denominator == 0)
                {
                    
                    result[index] = 0;
                }
                else
                {
                    
                    
                    double fx = 3 * x + 2 - ((2 * x) - x) / denominator;

                    
                    fx = Math.Round(fx, 2);

                    
                    result[index] = fx;
                }

                
                index++;
            }

            
            return result;
        }
    }
}
