﻿using Tyuiu.NovikovaVA.Sprint3.Task7.V3.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТН-б-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции ()         *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапозоне [-5; 5] с шагом 1 *");
            Console.WriteLine("* Произвести проверку деления на 0. При делении на ноль вернуть значение 0*");
            Console.WriteLine("* Значения округлить до двух знаков после запятой                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+---------------+");
            Console.WriteLine("|    X     |   f(x)        |");
            Console.WriteLine("+----------+---------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |   {1,6:f2}      |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+---------------+");
            Console.ReadKey();
        }
    }
}
