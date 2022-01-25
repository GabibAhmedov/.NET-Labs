using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearAlgebra;
using VectorException;

namespace Unit_Test_Project
{
    [TestClass]
    public class VectorTest1
    {
        [TestMethod]
        public void DimensionsOkTest()
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
        public void DimensionsErrorTest()
        {
            //arrange
            //var vec = new MathVector(5, -5);
            int expected = 5;

            //act
           // double result = vec.Dimensions;

            //accert
            Assert.ThrowsException<VectorSizeException>(() => new MathVector(-5,5));

        }
        [TestMethod]
        public void LengthTestOk()
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
        public void SumNumberTestOk()
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
        public void SumOkTest()
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
        public void SumErrorTest()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeException>(() => vec1.Sum(vec2));

        }
        [TestMethod]
        public void MultiplyNumberOkTest()
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
        public void MultiplyOkTest()
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
        public void MultiplyErrorTest()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeException>(() => vec1.Multiply(vec2));

        }
        [TestMethod]
        public void ScalarMultiplyOkTest()
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
        public void ScalarMultiplyErrorTest()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeException>(() => vec1.ScalarMultiply(vec2));

        }
        [TestMethod]
        public void CalcDistanceOkTest()
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
        public void CalcDistanceErrorTest()
        {
            //arrange
            IMathVector vec1 = new MathVector(4, 5);
            IMathVector vec2 = new MathVector(5, 7);
            IMathVector expected = new MathVector(4, 6);

            //act
            //IMathVector result = vec1.Sum(vec2);

            //accert
            Assert.ThrowsException<VectorSizeException>(() => vec1.CalcDistance(vec2));

        }
        [TestMethod]
        public void OperatorVectorPlusNumberOkTest()
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
        public void OperatorVectorPlusVectorOk  Test()
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
        [TestMethod]
        public void TestOperatorDivide_VecByNumError()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            double num = 0;
            //MathVector expected = new MathVector(4, 1);

            //act
           // IMathVector result = (MathVector)vec1 / num;

            //accert
            Assert.ThrowsException<VectorMathException>(() => vec1/num);

        }
        [TestMethod]
        public void TestOperatorDivide_VectorByNumOk()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            double num = 5;
            MathVector expected = new MathVector(4, 1);

            //act
            IMathVector result = (MathVector)vec1 / num;

            //accert
            Assert.AreEqual(expected, result);

        }
       // [TestMethod]
       /* public void TestOperatorDivide3()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            double num = 2;
            MathVector expected = new MathVector(4, 2.5);

            //act
            IMathVector result = (MathVector)vec1 / num;

            //accert
            Assert.AreEqual(expected, result);

        }*/
        [TestMethod]
        public void OperatorDivideVectorByVectorOkTest()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            MathVector vec2 = new MathVector(4, 5);
            MathVector expected = new MathVector(4, 1);

            //act
            IMathVector result = (MathVector)vec1 / (MathVector)vec2;

            //accert
            Assert.AreEqual(expected, result);

        }
        public void OperatorDivideVectorByVectorErrorTest()
        {
            //arrange
            MathVector vec1 = new MathVector(4, 5);
            MathVector vec2 = new MathVector(4, 0);
           

            //act
           

            //accert
            Assert.ThrowsException<VectorMathException>(() => vec1 / vec2);

        }
    }
}
