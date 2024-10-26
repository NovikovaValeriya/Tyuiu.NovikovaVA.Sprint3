using Tyuiu.NovikovaVA.Sprint3.Task3.V10.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТН-б-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы p в строке:          *");
            Console.WriteLine("* gdfppf vfppt p                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "gdfppf vfppt p"; char item = 'p';

            Console.WriteLine("Исходная строка " + value);
            Console.WriteLine("Искомый символ " + item);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine( "Найдено символов: "+ds.DeleteCharInString( value,  item));
            Console.ReadKey();
        }
    }
}
