using System;
using Cuni.Arithmetics.FixedPoint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
        [TestClass]
        public class IntegersTestsForQ16_16
        {
            [TestMethod]
            public void Addicion1()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Add(f2);
                Assert.AreEqual("5", f3.ToString());
            }
            [TestMethod]
            public void Addicion2()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(-3);
                var f3 = f1.Add(f2);
                Assert.AreEqual("0", f3.ToString());
            }
            [TestMethod]
            public void Addicion3()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(-20000);
                var f3 = f1.Add(f2);
                Assert.AreEqual("-19997", f3.ToString());
            }
            [TestMethod]
            public void Substraction1()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Substract(f2);
                Assert.AreEqual("1", f3.ToString());
            }
            [TestMethod]
            public void Substraction2()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(3);
                var f3 = f1.Substract(f2);
                Assert.AreEqual("0", f3.ToString());
            }
            [TestMethod]
            public void Substraction3()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(4);
                var f3 = f1.Substract(f2);
                Assert.AreEqual("-1", f3.ToString());
            }
            [TestMethod]
            public void Multiplication1()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(4);
                var f3 = f1.Multiply(f2);
                Assert.AreEqual("12", f3.ToString());
            }
            [TestMethod]
            public void Multiplication2()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(0);
                var f3 = f1.Multiply(f2);
                Assert.AreEqual("0", f3.ToString());
            }
            [TestMethod]
            public void Multiplication3()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(-4);
                var f3 = f1.Multiply(f2);
                Assert.AreEqual("-12", f3.ToString());
            }
            [TestMethod]
            public void Division1()
            {
                var f1 = new Fixed<Q16_16>(3);
                var f2 = new Fixed<Q16_16>(3);
                var f3 = f1.Divide(f2);
                Assert.AreEqual("1", f3.ToString());
            }
            [TestMethod]
            public void Division2()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(3);
                var f3 = f1.Divide(f2);
                Assert.AreEqual("3", f3.ToString());
            }
            [TestMethod]
            [ExpectedException(typeof(DivideByZeroException))]
            public void Division3()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(0);
                var f3 = f1.Divide(f2);
            }

            [TestMethod]
            [ExpectedException(typeof(OverflowException))]
            public void OverflowInConstructor()
            {
                var f1 = new Fixed<Q16_16>(8388609);
            }

            [TestMethod]
            [ExpectedException(typeof(OverflowException))]
            public void OverflowInConstructor2()
            {
                var f1 = new Fixed<Q16_16>(-8388609);
            }



        }

        [TestClass]
        public class RealNumbersTestsForQ16_16
        {
            [TestMethod]
            public void Addicion1()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Divide(f2);
                f3 = f3.Add(f2);
                Assert.AreEqual(((9.0 / 2.0) + 2).ToString(), f3.ToString());
            }
            [TestMethod]
            public void Substraction1()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Divide(f2);
                f3 = f3.Substract(f2);
                Assert.AreEqual(((9.0 / 2.0) - 2).ToString(), f3.ToString());
            }
            [TestMethod]
            public void Division1()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Divide(f2);
                Assert.AreEqual((9.0 / 2.0).ToString(), f3.ToString());
            }
            [TestMethod]
            public void Multiplication1()
            {
                var f1 = new Fixed<Q16_16>(9);
                var f2 = new Fixed<Q16_16>(2);
                var f3 = f1.Divide(f2);
                f3 = f3.Multiply(f2);
                Assert.AreEqual(((9.0 / 2.0) * 2).ToString(), f3.ToString());
            }
        }
    }
