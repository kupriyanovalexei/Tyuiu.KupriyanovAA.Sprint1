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
            // cos^3(x)
            double cosCubed = Math.Pow(Math.Cos(x), 3);

            // sin^5(x)
            double sinFifth = Math.Pow(Math.Sin(x), 5);

            // xy
            double xy = x * y;

            // z = x - cos^3(x)/(xy - 3) + sin^5(x)/(xy + 5)
            double z = x - (cosCubed / (xy - 3)) + (sinFifth / (xy + 5));

            // Округляем до 3 знаков после запятой
            return Math.Round(z, 3);
        }
    }
}