using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSloz()
        {
            var vector = new Vector();
            int[] vec1 = new int[] { 2, 5};
            int[] vec2 = new int[] { 3, 0};
            int[] result = vector.Sloz( vec1, vec2);
            int[] expected = new int[] { 5, 5};

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSkalar()
        {
            var vector = new Vector();
            int[] vec1 = new int[] { 2, 5 };
            int[] vec2 = new int[] { 3, 7 };
            var result = vector.Skalar(vec1, vec2);
            var expected = 41;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestOtnim()
        {
            var vector = new Vector();
            int[] vec1 = new int[] { 2, 5 };
            int[] vec2 = new int[] { 3, 0 };
            var result = vector.Otnim(vec1, vec2);
            var expected = new int[] { -1, 5 };

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestUmnoz()
        {
            var vector = new Vector();
            int[] vec1 = new int[] { 2, 5 };
            var result = vector.Umnoz(vec1, 3);
            var expected = new int[] { 6, 15 };

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestVectornoe()
        {
            var vector = new Vector();
            int[] vec1 = new int[] { 2, 5, 4 };
            int[] vec2 = new int[] { 3, 0, 7 };
            var result = vector.Vectorne(vec1, vec2);
            var expected = new int[] { 35, -2 , -15 };

            Assert.AreEqual(expected, result);
        }
    }
}
