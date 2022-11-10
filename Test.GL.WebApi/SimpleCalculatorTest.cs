using GL.WebApi.Controllers;
using GL.WebApi.Services;
using NUnit.Framework;

namespace Test.GL.WebApi
{
    public class SimpleCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5, 1, 6)]
        [TestCase(-9, -3, -12)]
        [TestCase(-2, -2, -4)]
        [TestCase(17, 34, 51)]
        public void AddTest(int start, int amount, int value)
        {
            // Arrange
            CalculatorController controller = new CalculatorController(new SimpleCalculatorService());

            // Act
            var result = controller.AddAsync(start, amount).Result;

            // Assert
            Assert.AreEqual(result, value, "AddAsync");
        }

        [Test]
        [TestCase(5, 1, 4)]
        [TestCase(-9, -3, -6)]
        [TestCase(-2, -2, -4)]
        [TestCase(17, 34, -17)]
        [TestCase(-8, -2, -6)]
        [TestCase(-2, -8, -10)]
        public void SubtractTest(int start, int amount, int value)
        {
            // Arrange
            CalculatorController controller = new CalculatorController(new SimpleCalculatorService());

            // Act
            var result = controller.SubtractAsync(start, amount).Result;

            // Assert
            Assert.AreEqual(result, value, "AddAsync");
        }
    }
}