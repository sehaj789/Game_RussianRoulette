using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_RussianRoulette;

namespace TestRussianRoulette
{
    [TestClass]
    public class UnitTest1
    {
        
        RRClass RR = new RRClass();

        [TestMethod]
        public void TestMethod1()
        {
            int x = RR.Bullet;
            Assert.AreNotEqual(x, 6);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int y = RR.Point;
            Assert.AreEqual(y, 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int z = RR.Shot;
            Assert.AreEqual(z, RR.Shot1 + RR.Shot2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = RR.Shot;
            Assert.AreNotEqual(a, 6);
        }
    }
}
