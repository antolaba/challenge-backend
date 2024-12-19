using System;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Portuges: Idioma
    {
        public override string EmptyListLabel => "Lista vazia de formas";
        public override string Header => "Relatório de formas";
        public override string AreaLabel => "Área";
        public override string PerimeterLabel => "Perímetro";
        public override string CuadradoSingularName => "Quadrado";
        public override string CuadradoPluralName => "Quadrados";
        public override string TrianguloEquilateroSingularName => "Triângulo";
        public override string TrianguloEquilateroPluralName => "Triângulos";
        public override string CirculoSingularName => "Círculo";
        public override string CirculoPluralName => "Círculos";
        public override string TrapecioSingularName => "Trapézio";
        public override string TrapecioPluralName => "Trapézios";
        public override string RectanguloSingularName => "Retângulo";
        public override string RectanguloPluralName => "Retângulos";
        public override string ShapesLabel => "formas";
        public override string TotalLabel => "total";
    }
}