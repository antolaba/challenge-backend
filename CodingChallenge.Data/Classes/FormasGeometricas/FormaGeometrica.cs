namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class FormaGeometrica
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract FormaGeometricaType Tipo { get; }
    }
}
