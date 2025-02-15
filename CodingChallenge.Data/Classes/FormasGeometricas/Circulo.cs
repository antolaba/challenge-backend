﻿using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo: FormaGeometrica
    {
        private decimal _diametro;

        public Circulo(decimal diametro)
        {
            if(diametro < 0) throw new ArgumentException(nameof(diametro));
            
            _diametro = diametro;
        }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return  (decimal)Math.PI * _diametro;
        }

        public override FormaGeometricaType Tipo { get { return FormaGeometricaType.Circulo; } }
    }
}