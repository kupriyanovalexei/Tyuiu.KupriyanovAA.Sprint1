using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task2.V10.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тестовое значение: 1 метр (целое число, как в интерфейсе)
            int meters = 1;

            // Вызываем правильный метод ConvertMetreToInchs
            var res = ds.ConvertMetreToInchs(meters);

            // Ожидаемый результат: 1 * 39.3701 = 39.3701 -> округляем до 39.37
            Assert.AreEqual(39.37, res);
        }
    }
}
