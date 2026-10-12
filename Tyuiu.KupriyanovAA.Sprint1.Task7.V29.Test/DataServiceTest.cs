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

            // Тестовые значения
            double x = 2;
            double y = 4;

            var res = ds.Calculate(x, y);

            // Ожидаемый результат: 2.072
            Assert.AreEqual(2.072, res);
        }
    }
}