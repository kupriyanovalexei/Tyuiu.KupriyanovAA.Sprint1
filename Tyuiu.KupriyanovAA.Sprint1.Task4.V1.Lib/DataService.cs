using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task4V1
    {
        // Метод принимает x и возвращает результат по формуле 1 / (x+2)^2
        public double Calculate(double x)
        {
            // Возводим в квадрат: Math.Pow(основание, степень)
            double result = 1 / Math.Pow(x + 2, 2);

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}