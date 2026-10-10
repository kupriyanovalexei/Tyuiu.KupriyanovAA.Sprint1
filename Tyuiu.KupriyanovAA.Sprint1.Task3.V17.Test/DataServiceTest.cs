using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тест 1: дробная часть 305 - есть ноль
            double value1 = 12.305;
            bool res1 = ds.ZeroCheck(value1);
            Assert.IsTrue(res1); // Ожидаем true

            // Тест 2: дробная часть 456 - нет нуля
            double value2 = 12.456;
            bool res2 = ds.ZeroCheck(value2);
            Assert.IsFalse(res2); // Ожидаем false
        }
    }
}
