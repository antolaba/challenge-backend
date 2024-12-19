using System;
using CodingChallenge.Data.Classes.Idiomas;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometricaTraductor
    {
        public Idioma _idioma;

        public FormaGeometricaTraductor(Idioma idioma)
        {
            _idioma = idioma;
        }
        
        public string GetSingularName(FormaGeometricaType type)
        {
            switch (type)
            {
                case FormaGeometricaType.Cuadrado:
                    return _idioma.CuadradoSingularName;
                case FormaGeometricaType.TrianguloEquilatero:
                    return _idioma.TrianguloEquilateroSingularName;
                case FormaGeometricaType.Circulo:
                    return _idioma.CirculoSingularName;
                case FormaGeometricaType.Trapecio:
                    return _idioma.TrapecioSingularName;
                case FormaGeometricaType.Rectangulo:
                    return _idioma.RectanguloSingularName;
                default:
                    throw new Exception("Unsupported FormaGeometricaType type for Idioma");
            }
        }

        public string GetPluralName(FormaGeometricaType type)
        {
            switch (type)
            {
                case FormaGeometricaType.Cuadrado:
                    return _idioma.CuadradoPluralName;
                case FormaGeometricaType.TrianguloEquilatero:
                    return _idioma.TrianguloEquilateroPluralName;
                case FormaGeometricaType.Circulo:
                    return _idioma.CirculoPluralName;
                case FormaGeometricaType.Trapecio:
                    return _idioma.TrapecioPluralName;
                case FormaGeometricaType.Rectangulo:
                    return _idioma.RectanguloPluralName;
                default:
                    throw new Exception("Unsupported FormaGeometricaType type for Idioma");
            }
        }

        public string getEmptyListLabel()
        {
            return _idioma.EmptyListLabel;
        }

        public string getHeader()
        {
            return this._idioma.Header;
        }

        public string getAreaLabel()
        {
            return _idioma.AreaLabel;
        }

        public string getPerimeterLabel()
        {
            return _idioma.PerimeterLabel;
        }

        public string getTotalLabel()
        {
            return _idioma.TotalLabel;
        }

        public string getShapesLabel()
        {
            return _idioma.ShapesLabel;
        }
    }
}