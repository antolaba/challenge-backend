using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio: FormaGeometrica
    {
        private decimal _altura;
        private decimal _baseMayor;
        private decimal _baseMenor;
        private decimal _lado1;
        private decimal _lado2;
        
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lado1, decimal lado2, decimal altura)
        {
            if(baseMayor < 0) throw new ArgumentException(nameof(baseMayor));
            
            if(baseMenor < 0) throw new ArgumentException(nameof(baseMenor));
            
            if(lado1 < 0) throw new ArgumentException(nameof(lado1));
            
            if(lado2 < 0) throw new ArgumentException(nameof(lado2));
            
            if(altura < 0) throw new ArgumentException(nameof(altura));

            _altura = altura;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _baseMayor + _baseMenor;
        }

        public override FormaGeometricaType Tipo { get { return FormaGeometricaType.Trapecio; } }
    }
}