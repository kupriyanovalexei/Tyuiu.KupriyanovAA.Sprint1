using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KupriyanovAA.Sprint1.Task1.V15.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task1.V15
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Куприянов Алексей Анатольевич | АСОиУб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (4+2*x)/7 и печатает его на экране.      *");
            Console.WriteLine("***************************************************************************");

            // Блок ввода данных
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine()); // Читаем строку и превращаем в число

            // Блок вывода результата
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Передаем введенный x в метод и печатаем результат
            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}