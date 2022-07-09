namespace ShapeLibrary.Model.Abstract
{
    public abstract class Figure
    {
        public string FigureName { get; set; } = string.Empty;
        public double Area { get; set; }

        public abstract double CalculatingArea();
    }
}
