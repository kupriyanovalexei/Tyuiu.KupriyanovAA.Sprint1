using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KupriyanovAA.Sprint1.Task7.V29.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task7.V29
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Алексей Анатольевич | АСОиУб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* z = x - cos^3(x)/(xy-3) + sin^5(x)/(xy+5).                              *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");

            // Блок ввода данных
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Блок вывода результата
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод и печатаем результат
            double z = ds.Calculate(x, y);
            Console.WriteLine($"* z = {z}");

            Console.ReadLine();
        }
    }
}