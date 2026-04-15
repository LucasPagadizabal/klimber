using System;

namespace DevelopmentChallenge.Data.Classes
{
    // Trapecio isósceles: dos bases paralelas y dos lados laterales iguales.
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura    = altura;
        }

        public override decimal CalcularArea()
            => (_baseMayor + _baseMenor) / 2 * _altura;

        public override decimal CalcularPerimetro()
        {
            double semidiferencia = (double)((_baseMayor - _baseMenor) / 2);
            double alt            = (double)_altura;
            decimal ladoLateral   = (decimal)Math.Sqrt(semidiferencia * semidiferencia + alt * alt);
            return _baseMayor + _baseMenor + 2 * ladoLateral;
        }

        public override string ObtenerNombre(int cantidad, IIdioma idioma)
            => idioma.ObtenerNombreForma("trapecio", cantidad);
    }
}
