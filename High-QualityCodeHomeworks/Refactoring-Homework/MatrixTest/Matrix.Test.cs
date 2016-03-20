namespace MatrixTest
{
    using System;

    using GameFifteen;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixT
    {
        private const string Matrix1Element = "  1\r\n";

        private const string Matrix2Elements = "  1  4\r\n  3  2\r\n";

        private const string Matrix3Elements = "  1  7  8\r\n  6  2  9\r\n  5  4  3\r\n";

        private const string Matrix4Elements = "  1 10 11 12\r\n  9  2 15 13\r\n  8 16  3 14\r\n  7  6  5  4\r\n";

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixWithSize0ShouldThrow()
        {
            var m = new Matrix(0);
        }

        [TestMethod]
        public void TestMatrixWithSize1ShouldReturnCorrectResult()
        {
            var m = new Matrix(1);
            Assert.AreEqual(m.ToString(), Matrix1Element);
        }

        [TestMethod]
        public void TestMatrixWithSize2ShouldReturnCorrectResult()
        {
            var m = new Matrix(2);
            Assert.AreEqual(m.ToString(), Matrix2Elements);
        }

        [TestMethod]
        public void TestMatrixWithSize3ShouldReturnCorrectResult()
        {
            var m = new Matrix(3);
            Assert.AreEqual(m.ToString(), Matrix3Elements);
        }

        [TestMethod]
        public void TestMatrixWithSize4ShouldReturnCorrectResult()
        {
            var m = new Matrix(4);
            Assert.AreEqual(m.ToString(), Matrix4Elements);
        }
    }
}