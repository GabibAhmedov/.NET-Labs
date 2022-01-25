using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearAlgebra;
using VectorExeption;

namespace Unit_Test_Project
{
    [TestClass]
    public class VectorTest1
    {
        [TestMethod]
        public void TestDimensions()
        {
            //arrange
            var vec = new MathVector(5, 1);
            int expected = 5;

            //act
            double result = vec.Dimensions;

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestLength()
        {
            //arrange
            var vec = new MathVector(4, 5);
            double expected = 10;

            //act
            double result = vec.Length;

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestSumNumber()
        {
            //arrange
            IMathVector vec = new MathVector(4, 5);
            double num = 1;
            IMathVector expected = new MathVector(4, 6);

            //act
            IMathVector result = vec.SumNumber(num);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestSum1()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(4, 7);
            IMathVector expected = new MathVector(4, 12);

            //act
            IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestSum2()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeExeption>(() => vec1.Sum(vec2));

        }
        [TestMethod]
        public void TestMultiplyNumber()
        {
            //arrange
            IMathVector vec = new MathVector(4, 5);
            double num = 2;
            IMathVector expected = new MathVector(4, 10);

            //act
            IMathVector result = vec.MultiplyNumber(num);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestMultiply1()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(4, 7);
            IMathVector expected = new MathVector(4, 35);

            //act
            IMathVector result = vec1.Multiply(vec2);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestMultiply2()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeExeption>(() => vec1.Multiply(vec2));

        }
        [TestMethod]
        public void ScalarMultiply1()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(4, 2);
            double expected = 10;

            //act
            double result = vec1.ScalarMultiply(vec2);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void ScalarMultiply2()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeExeption>(() => vec1.ScalarMultiply(vec2));

        }
        [TestMethod]
        public void TestCalcDistance1()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(4, 7);
            double expected = 4;

            //act
            double result = vec1.CalcDistance(vec2);

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestCalcDistance2()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeExeption>(() => vec1.CalcDistance(vec2));

        }
        [TestMethod]
        public void TestOperatorPlus1()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            double num = 1;
            MathVector expected = new MathVector(4, 6);

            //act
            IMathVector result = (MathVector)vec1 + 1;

            //accert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestOperatorPlus2()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            MathVector vec2 = new MathVector(4, 7);
            MathVector expected = new MathVector(4, 12);

            //act
            IMathVector result = (MathVector)vec1 + (MathVector)vec2;

            //accert
            Assert.AreEqual(expected, result);

        }

    }
}
