using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task1.V15.Lib
{
    public class DataService : ISprint1Task1V15
    {
        // Метод теперь принимает значение x типа double
        public double Calculate(double x)
        {
            // Вычисляем формулу: (4 + 2 * x) / 7
            return (4 + 2 * x) / 7;
        }
    }
}