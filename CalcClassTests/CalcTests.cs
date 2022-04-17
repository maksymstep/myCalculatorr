using CalcClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcClassTests
{
    [TestClass]
    public class CalcTests
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void Sum_20and45_36returned()
            {
                int a = 20;
                int b = 45;
                int expected = 65;
                int actual = Calc.Sum(a, b);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Div_9and3_3returned()
            {
                int a = 9;
                int b = 3;
                int expected = 3;
                int actual = Calc.Div(a, b);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Sub_3and2_1returned()
            {
                int a = 3;
                int b = 2;
                int expected = 1;
                int actual = Calc.Sub(a, b);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Mult_7and3_21returned()
            {
                int a =7;
                int b = 3;
                int expected = 21;
                int actual = Calc.Mul(a, b);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Mod_30and3_0returned()
            {
                int a = 30;
                int b = 3;
                int expected = 0;
                int actual = Calc.Mod(a, b);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void M_m8_8returned()
            {
                int a = -8;
                int expected = 8;
                int actual = Calc.M(a);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void P_8_m8returned()
            {
                int a = 8;
                int expected = -8;
                int actual = Calc.P(a);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
