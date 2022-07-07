using ShapeLibrary.Model;

namespace ShapeLibrary
{
    public class Formulas
    {
        public double CalculatingAreaTriangle(TriangleModel obj)
        {
            if (obj.A == 0 || obj.B == 0 || obj.C == 0)
            {
                throw new DivideByZeroException("Одна из сторон 0. Деление на 0 невозможно");
            }

            double p = obj.A + obj.B + obj.C;
            CheckisRectangularTriangle(obj);

            return Math.Sqrt(p / 2 * (p / 2 - obj.A) * (p / 2 - obj.B) * (p / 2 - obj.C));
        }


        public double CalculatingAreaCircle(CircleModel obj)
        {
            return Math.PI * Math.Pow(obj.Radius, 2);
        }

        private void CheckisRectangularTriangle(TriangleModel obj)
        {   // проверка на является ли треугольник прямоугольным.

            double[] mass = { obj.A, obj.B, obj.C };
            Array.Sort(mass);

            double BiggerSide = Math.Pow(mass.LastOrDefault(), 2);
            double OtherSide = Math.Pow(mass.FirstOrDefault(), 2) + Math.Pow(mass[1], 2);

            if (BiggerSide == OtherSide)
            {
                obj.isRectangularTriangle = true;

            }

            obj.isRectangularTriangle = false;
        }
    }
}
