﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NovikovaVA.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            do
            {
                multiplySeries *= (((Math.Pow(value,startValue))+1)*Math.Cos(4));
                startValue++;
            } while(startValue <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
