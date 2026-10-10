using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task1.V15.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Задаем тестовое значение x = 5
            double x = 5;

            // Передаем x в метод
            var res = ds.Calculate(x);

            // Ожидаемый результат: (4 + 2*5) / 7 = 2
            Assert.AreEqual(2, res);
        }
    }
}
