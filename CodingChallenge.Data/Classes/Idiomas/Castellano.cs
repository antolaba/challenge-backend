using System;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano: Idioma
    {
        public override string EmptyListLabel => "Lista vacía de formas";
        public override string Header => "Reporte de Formas";
        public override string AreaLabel => "Area";
        public override string PerimeterLabel => "Perimetro";
        public override string CuadradoSingularName => "Cuadrado";
        public override string CuadradoPluralName => "Cuadrados";
        public override string TrianguloEquilateroSingularName => "Triángulo";
        public override string TrianguloEquilateroPluralName => "Triángulos";
        public override string CirculoSingularName => "Círculo";
        public override string CirculoPluralName => "Círculos";
        public override string TrapecioSingularName => "Trapecio";
        public override string TrapecioPluralName => "Trapecios";
        public override string RectanguloSingularName => "Rectangulo";
        public override string RectanguloPluralName => "Rectangulos";
        public override string ShapesLabel => "formas";
        public override string TotalLabel => "total";
    }
}