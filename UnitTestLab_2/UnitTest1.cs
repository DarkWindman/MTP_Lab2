using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddit()
        {
            var vector1 = new Vector(3, 5, 0);
            var vector2 = new Vector(2, 0, 0);
            var result = vector1 + vector2;
            var expected = new Vector(5,5,0);
            Assert.AreEqual(result.x, expected.x);
            Assert.AreEqual(result.y, expected.y);
            Assert.AreEqual(result.z, expected.z);
        }
        [TestMethod]
        public void TestSubstract()
        {
            var vector1 = new Vector(3, 5, 1);
            var vector2 = new Vector(2, 0, 1);
            var result = vector1 - vector2;
            var expected = new Vector(1, 5, 0);
            Assert.AreEqual(result.x, expected.x);
            Assert.AreEqual(result.y, expected.y);
            Assert.AreEqual(result.z, expected.z);
        }

        [TestMethod]
        public void TestMultiConst()
        {
            var vector1 = new Vector(3, 5, 1);
            int b = 4;
            var result = vector1 * b;
            var expected = new Vector(12, 20, 4);
            Assert.AreEqual(result.x, expected.x);
            Assert.AreEqual(result.y, expected.y);
            Assert.AreEqual(result.z, expected.z);
        }

        [TestMethod]
        public void TestModuleMultipl()
        {
            var vector1 = new Vector(3, 5, 0);
            var vector2 = new Vector(2, 0, 0);
            var result = vector1.ModuleMultipl(vector1, vector2);
            var expected = 6;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestVectorMultipl()
        {
            var vector1 = new Vector(2, 5, 4);
            var vector2 = new Vector(3, 0, 7);
            var result = vector1 / vector2;
            var expected = new Vector(35, -2, -15);
            Assert.AreEqual(result.x, expected.x);
            Assert.AreEqual(result.y, expected.y);
            Assert.AreEqual(result.z, expected.z);
        }
    }

}
