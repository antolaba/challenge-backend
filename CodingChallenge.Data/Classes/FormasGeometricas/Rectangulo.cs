using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo: FormaGeometrica
    {
        private decimal _largo;
        private decimal _ancho;
        
        public Rectangulo(decimal largo, decimal ancho)
        {
            if(largo < 0) throw new ArgumentException(nameof(largo));
            
            if(ancho < 0) throw new ArgumentException(nameof(ancho));
            
            if(largo == ancho) throw new ArgumentException("Lados iguales");
            
            _largo = largo;
            _ancho = ancho;
        }

        public override decimal CalcularArea()
        {
            return _largo * _ancho;
        }

        public override decimal CalcularPerimetro()
        {
            return (_largo * 2) +  (_ancho * 2);
        }

        public override FormaGeometricaType Tipo { get { return FormaGeometricaType.Rectangulo; } }
    }
}