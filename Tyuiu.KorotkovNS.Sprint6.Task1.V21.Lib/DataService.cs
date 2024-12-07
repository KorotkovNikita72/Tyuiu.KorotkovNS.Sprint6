using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorotkovNS.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++, count++)
            {
                if ((2 - 2 * x) != 0)
                {
                    y = Math.Round(Math.Cos(x) + ((Math.Sin(x)) / (2 - 2 * x)) - 4 * x, 2);
                    valueArray[count] = y;
                    
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
