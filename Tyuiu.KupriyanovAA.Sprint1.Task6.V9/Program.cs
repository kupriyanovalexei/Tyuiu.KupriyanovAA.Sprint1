using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KupriyanovAA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task6.V9
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Куприянов Алексей Анатольевич | АСОиУб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Напечатать все слова, перенеся их последнюю  *");
            Console.WriteLine("* букву в начало.                                                         *");
            Console.WriteLine("***************************************************************************");

            // Блок ввода данных
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Введите текст: ");
            string value = Console.ReadLine();

            // Блок вывода результата
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод и печатаем результат
            string result = ds.MoveLetterToStart(value);
            Console.WriteLine($"* {result}");

            Console.ReadLine();
        }
    }
}