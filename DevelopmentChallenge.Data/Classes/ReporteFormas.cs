using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteFormas
    {
        public static string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.ObtenerMensajeListaVacia());
                return sb.ToString();
            }

            sb.Append(idioma.ObtenerEncabezado());

            decimal areaTotal      = 0;
            decimal perimetroTotal = 0;
            int     totalFormas    = 0;

            foreach (var grupo in formas.GroupBy(f => f.GetType()))
            {
                int     cantidad   = grupo.Count();
                decimal area       = grupo.Sum(f => f.CalcularArea());
                decimal perimetro  = grupo.Sum(f => f.CalcularPerimetro());
                string  nombre     = grupo.First().ObtenerNombre(cantidad, idioma);

                sb.Append($"{cantidad} {nombre} | Area {area:#.##} | {idioma.ObtenerEtiquetaPerimetro()} {perimetro:#.##} <br/>");

                areaTotal      += area;
                perimetroTotal += perimetro;
                totalFormas    += cantidad;
            }

            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalFormas} {idioma.ObtenerEtiquetaFormas()} ");
            sb.Append($"{idioma.ObtenerEtiquetaPerimetro()} {perimetroTotal:#.##} ");
            sb.Append($"Area {areaTotal:#.##}");

            return sb.ToString();
        }
    }
}
