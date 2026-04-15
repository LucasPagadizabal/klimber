using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "cuadrado",  ("Quadrato",  "Quadrati")  },
                { "circulo",   ("Cerchio",   "Cerchi")    },
                { "triangulo", ("Triangolo", "Triangoli") },
                { "trapecio",  ("Trapezio",  "Trapezi")   }
            };

        public string ObtenerEncabezado()        => "<h1>Rapporto sulle forme</h1>";
        public string ObtenerMensajeListaVacia() => "<h1>Lista vuota di forme!</h1>";
        public string ObtenerEtiquetaFormas()    => "forme";
        public string ObtenerEtiquetaPerimetro() => "Perimetro";

        public string ObtenerNombreForma(string clave, int cantidad)
        {
            var (singular, plural) = _nombres[clave];
            return cantidad == 1 ? singular : plural;
        }
    }
}
