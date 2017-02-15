using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Тестовое_задание;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        SetsSystem setsSystem;

        [TestInitialize]
        public void TestInitialize()
        {
            int[] tag = { 2, 3, 4, 5,  9, 10, 11, 12,16, 17, 18, 19 };
            setsSystem = new SetsSystem(tag);
            setsSystem.Union(2, 10);
            setsSystem.Union(4, 11);
            setsSystem.Union(10, 11);
            setsSystem.Union(11, 17);
            setsSystem.Union(10, 17);
        }


        [TestMethod]
        public void CheckInitialValues()
        {
            Assert.IsTrue(setsSystem.Find(10, 11));
            Assert.IsTrue(setsSystem.Find(17, 10));
            Assert.IsFalse(setsSystem.Find(17, 5));
            Assert.IsFalse(setsSystem.Find(9, 19));

        }

        [TestMethod]
        public void AddValue()
        {
            setsSystem.Add(1);

            Assert.IsFalse(setsSystem.Find(1, 19));

        }
        [TestMethod]
        public void BindingElements()
        {
            setsSystem.Add(1);
            setsSystem.Union(1, 3);
            Assert.IsTrue(setsSystem.Find(1, 3));
            setsSystem.Union(10, 3);
            Assert.IsTrue(setsSystem.Find(1, 3));
            Assert.IsTrue(setsSystem.Find(10, 3));


        }

        [TestMethod]
        public void Default()
        { 
            var sets = new SetsSystem(0,1,2,3,4,5,6,7);
            sets.Union(1, 4);
            sets.Union(4, 5);
            sets.Union(2, 3);
            sets.Union(2, 6);
            sets.Union(6, 3);
            sets.Union(3, 7);

            Assert.IsTrue(sets.Union(2, 5));
            Assert.IsFalse(sets.Find(0, 1));
            Assert.IsFalse(sets.Find(1,5));///тест по моему вопросу

        }


    }
}
