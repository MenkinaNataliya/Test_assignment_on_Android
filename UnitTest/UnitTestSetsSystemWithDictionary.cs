using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Тестовое_задание;

namespace UnitTest
{
    [TestClass]
    public class UnitTestSetsSystemWithDictionary
    {
        SetsSystemWithDictionary setsSystemDictionary;

        [TestInitialize]
        public void TestInitialize()
        {
            int[] tag = { 2, 3, 4, 5, 9, 10, 11, 12, 16, 17, 18, 19 };
            setsSystemDictionary = new SetsSystemWithDictionary(tag);
            setsSystemDictionary.Union(2, 10);
            setsSystemDictionary.Union(4, 11);
            setsSystemDictionary.Union(10, 11);
            setsSystemDictionary.Union(11, 17);
            setsSystemDictionary.Union(10, 17);
        }


        [TestMethod]
        public void CheckInitialValues()
        {
            Assert.IsTrue(setsSystemDictionary.Find(10, 11));
            Assert.IsTrue(setsSystemDictionary.Find(17, 10));
            Assert.IsFalse(setsSystemDictionary.Find(17, 5));
            Assert.IsFalse(setsSystemDictionary.Find(9, 19));

        }

        [TestMethod]
        public void AddValue()
        {
            setsSystemDictionary.Add(1);

            Assert.IsFalse(setsSystemDictionary.Find(1, 19));

        }
        [TestMethod]
        public void BindingElements()
        {
            setsSystemDictionary.Add(1);
            setsSystemDictionary.Union(1, 3);
            Assert.IsTrue(setsSystemDictionary.Find(1, 3));
            setsSystemDictionary.Union(10, 3);
            Assert.IsTrue(setsSystemDictionary.Find(1, 3));
            Assert.IsTrue(setsSystemDictionary.Find(10, 3));


        }

        [TestMethod]
        public void Default()
        {
            var sets = new SetsSystemWithDictionary(0, 1, 2, 3, 4, 5, 6, 7);
            sets.Union(1, 4);
            sets.Union(4, 5);
            sets.Union(2, 3);
            sets.Union(2, 6);
            sets.Union(6, 3);
            sets.Union(3, 7);

            Assert.IsTrue(sets.Union(2, 5));
            Assert.IsFalse(sets.Find(0, 1));
            Assert.IsFalse(sets.Find(1, 5));//тест по моему вопросу

        }
    }
}
