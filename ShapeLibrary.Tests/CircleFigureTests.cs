using ShapeLibrary.Model;

namespace ShapeLibrary.Tests
{
    public class CircleFigureTests
    {
        [Test]
        public void CalculatingAreaTriangleTest()
        {
            // Arrange
            double expectedAreaFigure = 113.09733552923255;
            Circle testModel = new Circle(6);

            // Act
            double actual = testModel.CalculatingArea();

            // Assert
            Assert.IsNotNull(actual);
            Assert.That(actual, Is.EqualTo(expectedAreaFigure));
        }

        [Test]
        public void CreateNewObjectTriangleTest_WhereSideisZeroOrNegativeValue_ShouldThrowArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-12));
        }

    }
}
