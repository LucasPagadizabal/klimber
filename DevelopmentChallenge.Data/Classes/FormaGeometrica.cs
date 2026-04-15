namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string ObtenerNombre(int cantidad, IIdioma idioma);
    }
}
