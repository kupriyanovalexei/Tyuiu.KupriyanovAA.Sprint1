using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KupriyanovAA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KupriyanovAA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Тестовая строка
            string value = "hello world";

            // Вызываем метод
            var res = ds.MoveLetterToStart(value);

            // Ожидаемый результат: "ohell dworl"
            Assert.AreEqual("ohell dworl", res);
        }
    }
}