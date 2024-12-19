using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero: FormaGeometrica
    {
        private decimal _lado;
        
        public TrianguloEquilatero(decimal lado)
        {
            if(lado < 0) throw new ArgumentException(nameof(lado));

            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override FormaGeometricaType Tipo { get { return FormaGeometricaType.TrianguloEquilatero; } }
    }
}