using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Editors;
using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.Classes.Idiomas;

namespace CodingChallenge.Data.Services
{
    public class FormaGeometricaService
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma,Editor editor)
        {
            var traductor = new FormaGeometricaTraductor(idioma);
            
            if (!formas.Any())
            {
                editor.WriteTitle(traductor.getEmptyListLabel() + "!");

                return editor.Text;
            }
            
            editor.WriteTitle(traductor.getHeader());

            var totalFigures = 0;
            var totalArea = 0m;
            var totalPerimeter = 0m;
            
            var formaGeometricasGroup = formas.GroupBy(r => r.Tipo);

            foreach (var formaGeometricaGroup in formaGeometricasGroup)
            {
                var formaGeometricas = formaGeometricaGroup.ToList();
                
                var formaGeometricasType = formaGeometricaGroup.Key;
                var total = formaGeometricas.Count;
                var area = formaGeometricas.Select(r => r.CalcularArea()).Sum();
                var perimeter = formaGeometricas.Select(r => r.CalcularPerimetro()).Sum();
                
                totalPerimeter += perimeter;
                totalArea += area;
                totalFigures += total;
                
                editor.WriteLine(ObtenerLinea(total,area,perimeter, formaGeometricasType, traductor));
                editor.AddLineBreak();
            }
            
            editor.WriteLine(traductor.getTotalLabel().ToUpper() + ":");
            editor.AddLineBreak();
            
            editor.WriteLine(totalFigures+ " " + traductor.getShapesLabel() + " ");
            editor.WriteLine(traductor.getPerimeterLabel() + " " + totalPerimeter.ToString("#.##") + " ");
            editor.WriteLine(traductor.getAreaLabel() + " " + totalArea.ToString("#.##"));
            
            return editor.Text;
        }
        
        private static string ObtenerLinea(int cantidad,decimal area, decimal perimeter, FormaGeometricaType type, FormaGeometricaTraductor traductor)
        {
            if (cantidad <= 0) return string.Empty;

            string name = cantidad == 1?  traductor.GetSingularName(type) : traductor.GetPluralName(type);
                
            return $"{cantidad} {name} | {traductor.getAreaLabel()} {area:#.##} | {traductor.getPerimeterLabel()} {perimeter:#.##} ";
        }
    }
}