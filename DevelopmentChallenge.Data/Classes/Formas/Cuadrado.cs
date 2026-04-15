namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()      => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;

        public override string ObtenerNombre(int cantidad, IIdioma idioma)
            => idioma.ObtenerNombreForma("cuadrado", cantidad);
    }
}
