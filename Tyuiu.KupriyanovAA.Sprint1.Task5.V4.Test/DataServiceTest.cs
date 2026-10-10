using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тестовое значение: 13257 секунд (пример из условия)
            int time = 13257;

            // Вызываем метод
            var res = ds.SecondsToHours(time);

            // Ожидаемый результат: 13257 / 3600 = 3 полных часа
            Assert.AreEqual(3, res);
        }
    }
}
