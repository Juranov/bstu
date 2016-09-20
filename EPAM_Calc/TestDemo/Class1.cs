using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM_Calc;


namespace TestDemo
{
    public class Class1
    {
        [Test]
        public void Test2addition2()
        {
            Program calc = new Program();
            Assert.AreEqual(4, calc.Addition (2,2));
        }

        [Test]
        public void Test4addition5()
        {
            Program calc = new Program();
            Assert.AreEqual(9, calc.Addition(4, 5));
        }

        [Test]
        public void Test7addition16()
        {
            Program calc = new Program();
            Assert.AreEqual(23, calc.Addition(7, 16));
        }

        [Test]
        public void Test2subtraction2()
        {
            Program calc = new Program();
            Assert.AreEqual(0, calc.Subtraction(2, 2));
        }

        [Test]
        public void Test5subtraction7()
        {
            Program calc = new Program();
            Assert.AreEqual(-2, calc.Subtraction(5, 7));
        }

        [Test]
        public void Test16subtraction16()
        {
            Program calc = new Program();
            Assert.AreEqual(0, calc.Subtraction(16, 16));
        }

        [Test]
        public void Test5divide0()
        {
            Program calc = new Program();
            Assert.AreEqual(0, calc.Division(5, 0));
        }

        [Test]
        public void Test6divide2()
        {
            Program calc = new Program();
            Assert.AreEqual(3, calc.Division(6, 2));
        }

        [Test]
        public void Test5divide1()
        {
            Program calc = new Program();
            Assert.AreEqual(5, calc.Division(5, 1));
        }

        [Test]
        public void Test6multiplication0()
        {
            Program calc = new Program();
            Assert.AreEqual(0, calc.Multiplication(6, 0));
        }

        [Test]
        public void Test7multiplication2()
        {
            Program calc = new Program();
            Assert.AreEqual(14, calc.Multiplication(7, 2));
        }

        [Test]
        public void Test8multiplication8()
        {
            Program calc = new Program();
            Assert.AreEqual(64, calc.Multiplication(8, 8));
        }
    }
}
