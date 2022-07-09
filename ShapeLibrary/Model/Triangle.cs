using ShapeLibrary.Model.Abstract;

namespace ShapeLibrary.Model
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Сторона не может быть равен нулю или меньше. Такого треугольника не существует!");
            }

            A = a;
            B = b;
            C = c;
        }

        public bool isRectangularTriangle()
        {
            double[] mass = { A, B, C };
            Array.Sort(mass);

            double BiggerSide = Math.Pow(mass.LastOrDefault(), 2);
            double OtherSide = Math.Pow(mass.FirstOrDefault(), 2) + Math.Pow(mass[1], 2);

            if (BiggerSide == OtherSide)
            {
                return true;
            }
            else { return false; }
        }

        public override double CalculatingArea()
        {
            double p = A + B + C;

            Area = Math.Sqrt(p / 2 * (p / 2 - A) * (p / 2 - B) * (p / 2 - C));

            if (Area is double.NaN)
            {
                throw new NotFiniteNumberException("Такого треугольника не существует");
            }

            return Area;
        }
    }
}
