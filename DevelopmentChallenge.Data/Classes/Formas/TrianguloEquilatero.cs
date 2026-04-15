using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
            => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

        public override decimal CalcularPerimetro()
            => _lado * 3;

        public override string ObtenerNombre(int cantidad, IIdioma idioma)
            => idioma.ObtenerNombreForma("triangulo", cantidad);
    }
}
