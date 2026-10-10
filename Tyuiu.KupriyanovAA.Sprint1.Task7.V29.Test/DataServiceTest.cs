using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task7.V29.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тестовые значения: x = 1, y = 1
            double x = 1;
            double y = 1;

            // Вызываем метод
            var res = ds.Calculate(x, y);

            // Ожидаемый результат (посчитано на калькуляторе): примерно 1.149
            // Если тест упадёт заменить значение на то, что выдаст программа.
            Assert.AreEqual(1.149, res, 0.001); // 0.001 — допустимая погрешность
        }
    }
}
