using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : IIdioma
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "cuadrado",  ("Square",    "Squares")    },
                { "circulo",   ("Circle",    "Circles")    },
                { "triangulo", ("Triangle",  "Triangles")  },
                { "trapecio",  ("Trapezoid", "Trapezoids") }
            };

        public string ObtenerEncabezado()        => "<h1>Shapes report</h1>";
        public string ObtenerMensajeListaVacia() => "<h1>Empty list of shapes!</h1>";
        public string ObtenerEtiquetaFormas()    => "shapes";
        public string ObtenerEtiquetaPerimetro() => "Perimeter";

        public string ObtenerNombreForma(string clave, int cantidad)
        {
            var (singular, plural) = _nombres[clave];
            return cantidad == 1 ? singular : plural;
        }
    }
}
