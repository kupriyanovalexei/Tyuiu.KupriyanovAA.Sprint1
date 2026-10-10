using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovAA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        // Метод принимает количество секунд time и возвращает количество полных часов
        public int SecondsToHours(int time)
        {
            // 1 час = 3600 секунд. Целочисленное деление отбрасывает остаток.
            int h = time / 3600;

            return h;
        }
    }
}