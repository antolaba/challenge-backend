using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado: FormaGeometrica
    {
        private decimal _lado;
        
        public Cuadrado(decimal lado)
        {
            if(lado < 0) throw new ArgumentException(nameof(lado));

            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override FormaGeometricaType Tipo { get { return FormaGeometricaType.Cuadrado; } }
    }
}