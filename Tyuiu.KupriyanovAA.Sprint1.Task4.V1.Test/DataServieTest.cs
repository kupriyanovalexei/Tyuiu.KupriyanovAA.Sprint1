using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тестовое значение: x = 0
            double x = 0;

            // Вызываем метод
            var res = ds.Calculate(x);

            // Ожидаемый результат: 1 / (0+2)^2 = 1/4 = 0.25
            Assert.AreEqual(0.25, res);
        }
    }
}