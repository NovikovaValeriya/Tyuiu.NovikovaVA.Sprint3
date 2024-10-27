using Tyuiu.NovikovaVA.Sprint3.Task6.V26.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: обработка целочисленных значенй                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТН-б-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [15, 22] количество всех делителей      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 15; int stopValue = 22;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
