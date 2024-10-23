using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NovikovaVA.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sum += ((Math.Pow(value, i) + 1) * Math.Cos(i));
            }


            return Math.Round(sum, 3, MidpointRounding.AwayFromZero);
        }
    }
}
