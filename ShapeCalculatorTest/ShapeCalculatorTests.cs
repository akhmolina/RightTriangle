using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangleShape
{
    [TestClass]
    public class ShapeCalculatorTests
    {
        public const string NotRightTriangelExceptionMessage = "Triangle is not right";

        [TestMethod]
        public void CalculateRightTriangleShape_RightTriangle_ReturnsShape()
        {
            // arrange
            double a = 4;
            double b = 3;
            double c = 5;
            double rightshape = 12;

            // act
            double shape = ShapeCalculator.CalculateRightTriangleShape(a,b,c);

            // assert
            Assert.AreEqual(rightshape, shape, 0.001 , "The fight triangle shape not calculaned correctly.");
        }

        [TestMethod]
        public void CalculateRightTriangleShape_LessThenZeroSide_ThrowsArgumentException()
        {
            // arrange
            double a = 4;
            double b = -3;
            double c = 5;

            // act
            try
            {
                double shape = ShapeCalculator.CalculateRightTriangleShape(a, b, c);
            }
            // assert
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.ParamName, "b");
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void CalculateRightTriangleShape_NotRightTriangle_ThrowsException()
        {
            // arrange
            double a = 5;
            double b = 3;
            double c = 5;

            // act
            try
            {
                double shape = ShapeCalculator.CalculateRightTriangleShape(a, b, c);
            }
            // assert
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, NotRightTriangelExceptionMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }
}
