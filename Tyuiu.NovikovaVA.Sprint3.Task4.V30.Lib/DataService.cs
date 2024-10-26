using  tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NovikovaVA.Sprint3.Task4.V30.Lib
{
    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res + (Math.Sin(x) / x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
