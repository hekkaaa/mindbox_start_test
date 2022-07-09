using ShapeLibrary.Model;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class TriangleFigureTests
    {
        [Test]
        public void CalculatingAreaTriangleTest()
        {
            // Arrange
            double expectedAreaFigure = 25.98076211353316;
            Triangle testModel = new Triangle(6, 14, 10);

            // Act
            double actual = testModel.CalculatingArea();

            // Assert
            Assert.IsNotNull(actual);
            Assert.That(actual, Is.EqualTo(expectedAreaFigure));
        }

        [Test]
        public void CalculatingRectangularTriangleTest_WhereTriangleIsRectangularIsTrue()
        {
            // Arrange
            bool expectedIsRectangularTriangle = true;
            Triangle testModel = new Triangle(24, 7, 25);

            // Act
            bool actual = testModel.isRectangularTriangle();

            // Assert
            Assert.IsNotNull(actual);
            Assert.That(actual, Is.EqualTo(expectedIsRectangularTriangle));
        }

        [Test]
        public void CalculatingRectangularTriangleTest_WhereTriangleRectangularIsFalse()
        {
            // Arrange
            bool expectedIsRectangularTriangle = false;
            Triangle testModel = new Triangle(12, 9, 12);

            // Act
            bool actual = testModel.isRectangularTriangle();

            // Assert
            Assert.IsNotNull(actual);
            Assert.That(actual, Is.EqualTo(expectedIsRectangularTriangle));
        }

        [Test]
        public void CreateNewObjectTriangleTest_WhereOneSideisZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(12, 3, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(12, 0, 12));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 3, 12));
        }

        [Test]
        public void CalculatingAreaTriangleTest_WhereTriangleDoesNotExist_ShouldThrowNotFiniteNumberException()
        {   
            // Arrange
            double expectedAreaFigure = 25.98076211353316;
            Triangle testModel = new Triangle(4, 44, 12);

            // Act

            // Assert
            Assert.Throws<NotFiniteNumberException>(() => testModel.CalculatingArea());
        }

        [Test]
        public void CreateNewObjectTriangleTest_WhereOneSideTriangleIsLessThanZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-12, 9, 12));
        }
    }
}
