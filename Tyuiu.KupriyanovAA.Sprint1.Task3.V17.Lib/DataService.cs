using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        // Метод принимает вещественное число и возвращает true, если среди первых 3 цифр дробной части есть 0
        public bool ZeroCheck(double number)
        {
            // 1. Умножаем на 1000, чтобы "сдвинуть" первые 3 цифры дробной части в целую часть
            // 2. Берем модуль (на случай отрицательных чисел) и приводим к int
            int shifted = (int)Math.Abs(number * 1000);

            // 3. Выделяем последние 3 цифры (это и есть первые 3 цифры дробной части)
            int lastThreeDigits = shifted % 1000;

            // 4. Разбираем на отдельные цифры
            int digit1 = lastThreeDigits / 100;        // Сотни
            int digit2 = (lastThreeDigits / 10) % 10;  // Десятки
            int digit3 = lastThreeDigits % 10;         // Единицы

            // 5. Проверяем, есть ли среди них ноль
            return digit1 == 0 || digit2 == 0 || digit3 == 0;
        }
    }
}