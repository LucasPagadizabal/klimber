using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : IIdioma
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "cuadrado",  ("Cuadrado",  "Cuadrados")  },
                { "circulo",   ("Círculo",   "Círculos")   },
                { "triangulo", ("Triángulo", "Triángulos") },
                { "trapecio",  ("Trapecio",  "Trapecios")  }
            };

        public string ObtenerEncabezado()        => "<h1>Reporte de Formas</h1>";
        public string ObtenerMensajeListaVacia() => "<h1>Lista vacía de formas!</h1>";
        public string ObtenerEtiquetaFormas()    => "formas";
        public string ObtenerEtiquetaPerimetro() => "Perimetro";

        public string ObtenerNombreForma(string clave, int cantidad)
        {
            var (singular, plural) = _nombres[clave];
            return cantidad == 1 ? singular : plural;
        }
    }
}
