namespace CodingChallenge.Data.Classes.Idiomas
{
    public abstract class Idioma
    {
        /// <summary>
        ///  Label cuando la lista esta vacio
        /// </summary>
        public abstract string EmptyListLabel { get; }
        /// <summary>
        ///  Header para lista
        /// </summary>
        public abstract string Header { get; }
        /// <summary>
        ///  Label de area
        /// </summary>
        public abstract string AreaLabel { get; }
        /// <summary>
        ///  Label para perimetro
        /// </summary>
        public abstract string PerimeterLabel { get; }
        /// <summary>
        ///  Label para cuadrado singular
        /// </summary>
        public abstract string CuadradoSingularName { get; }
        /// <summary>
        ///  Label para cuadrado plural
        /// </summary>
        public abstract string CuadradoPluralName{ get; }
        /// <summary>
        ///  Label para triangulo equilatero singular
        /// </summary>
        public abstract string TrianguloEquilateroSingularName { get; }
        /// <summary>
        ///  Label para triangulo equilatero plural
        /// </summary>
        public abstract string TrianguloEquilateroPluralName{ get; }
        /// <summary>
        ///  Label para circulo singular
        /// </summary>
        public abstract string CirculoSingularName { get; }
        /// <summary>
        ///  Label para circulo plural
        /// </summary>
        public abstract string CirculoPluralName{ get; }
        /// <summary>
        ///  Label para trapecio singular
        /// </summary>
        public abstract string TrapecioSingularName { get; }
        /// <summary>
        ///  Label para trapecio plural
        /// </summary>
        public abstract string TrapecioPluralName{ get; }
        /// <summary>
        ///  Label para rectangulo singular
        /// </summary>
        public abstract string RectanguloSingularName { get; }
        /// <summary>
        ///  Label para rectangulo plural
        /// </summary>
        public abstract string RectanguloPluralName{ get; }
        /// <summary>
        ///  Label para formas
        /// </summary>
        public abstract string ShapesLabel { get; }
        /// <summary>
        ///  Label para total
        /// </summary>
        public abstract string TotalLabel { get; }
    }
}