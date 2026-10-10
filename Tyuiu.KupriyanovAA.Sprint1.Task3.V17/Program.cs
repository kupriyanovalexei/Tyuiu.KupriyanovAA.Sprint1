using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KupriyanovAA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Куприянов А. А. | АСОиУб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Алексей Анатольевич | АСОиУб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех цифр  *");
            Console.WriteLine("* из дробной части заданного вещественного числа цифра 0.                 *");
            Console.WriteLine("***************************************************************************");

            // Блок ввода данных
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Введите вещественное число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            // Блок вывода результата
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод ZeroCheck и выводим результат
            bool result = ds.ZeroCheck(number);

            if (result)
            {
                Console.WriteLine("* Среди первых трех цифр дробной части есть цифра 0.");
            }
            else
            {
                Console.WriteLine("* Среди первых трех цифр дробной части нет цифры 0.");
            }

            Console.ReadLine();
        }
    }
}