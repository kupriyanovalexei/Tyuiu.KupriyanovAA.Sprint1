using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        // Метод принимает x и y, возвращает результат по формуле
        public double Calculate(double x, double y)
        {
            // cos(x^3)
            double cosX3 = Math.Cos(Math.Pow(x, 3));

            // sin(x^5)
            double sinX5 = Math.Sin(Math.Pow(x, 5));

            // xy
            double xy = x * y;

            // z = x - cos(x^3)/(xy - 3) + sin(x^5)/(xy + 5)
            double z = x - (cosX3 / (xy - 3)) + (sinX5 / (xy + 5));

            // Округляем до 3 знаков после запятой
            return Math.Round(z, 3);
        }
    }
}