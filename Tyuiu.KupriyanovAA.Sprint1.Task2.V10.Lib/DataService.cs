using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            double inches = value * 39.3701;

            // Округляем до 3 знаков после запятой и возвращаем
            return Math.Round(inches, 3);
        }
    }
}