using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public override decimal CalcularArea()
            => (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);

        public override decimal CalcularPerimetro()
            => (decimal)Math.PI * _diametro;

        public override string ObtenerNombre(int cantidad, IIdioma idioma)
            => idioma.ObtenerNombreForma("circulo", cantidad);
    }
}
