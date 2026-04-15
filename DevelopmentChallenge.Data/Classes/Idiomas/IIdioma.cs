namespace DevelopmentChallenge.Data.Classes
{
    public interface IIdioma
    {
        string ObtenerEncabezado();
        string ObtenerMensajeListaVacia();
        string ObtenerEtiquetaFormas();
        string ObtenerEtiquetaPerimetro();
        string ObtenerNombreForma(string clave, int cantidad);
    }
}
