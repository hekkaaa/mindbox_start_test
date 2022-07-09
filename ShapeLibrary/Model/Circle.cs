using ShapeLibrary.Model.Abstract;

namespace ShapeLibrary.Model
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть равен нулю иил меньше. Такого круга не существует!");
            }

            this.Radius = radius;
        }

        public override double CalculatingArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
