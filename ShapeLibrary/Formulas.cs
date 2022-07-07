using ShapeLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Formulas
    {
        public double CalculatingArea(TriangleModel obj)
        {
            double p = obj.A + obj.B + obj.C;
            return Math.Sqrt(p / 2 * (p / 2 - obj.A) * (p / 2 - obj.B) * (p / 2 - obj.C));
        }
    }
}
