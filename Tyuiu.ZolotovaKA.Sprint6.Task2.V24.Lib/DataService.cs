
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZolotovaKA.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + x * 2, 2);

                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                }
            }
            return valueArray;
        }
    }
}