using System;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles: Idioma
    {
        public override string EmptyListLabel => "Empty list of shapes";
        public override string Header => "Shapes report";
        public override string AreaLabel => "Area";
        public override string PerimeterLabel => "Perimeter";
        public override string CuadradoSingularName => "Square";
        public override string CuadradoPluralName => "Squares";
        public override string TrianguloEquilateroSingularName => "Triangle";
        public override string TrianguloEquilateroPluralName => "Triangles";
        public override string CirculoSingularName => "Circle";
        public override string CirculoPluralName => "Circles";
        public override string TrapecioSingularName => "Trapeze";
        public override string TrapecioPluralName => "Trapezoids";
        public override string RectanguloSingularName => "Rectangle";
        public override string RectanguloPluralName => "Rectangles";
        public override string ShapesLabel => "shapes";
        public override string TotalLabel => "total";
    }
}