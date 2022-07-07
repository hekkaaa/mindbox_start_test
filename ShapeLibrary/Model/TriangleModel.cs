using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Model
{
    public class TriangleModel
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public bool RectangularTriangle { get; set; }

        public TriangleModel(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
